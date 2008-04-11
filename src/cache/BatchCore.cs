using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((double)count >= (double)datum) && ((count ^ datum) >= datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Region { get; set; }
            public double Size { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 12; i++)
            {
                anchor = (anchor ^ ((long)i - anchor)) % 255;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftCount = 53.11;
        public const long BurstFactor = 2296;
        public const long LimitEntry = 6251;
    }
}
