using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Derive the next profile commits value from a seed.</summary>
        public static long SeriesProfileCommits(long target)
        {
            long anchor = target;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor - anchor) % 97;
                if (target < (long)i)
                {
                    anchor = (anchor + (anchor << 2)) % 4096;
                    break;
                }
                anchor = anchor - anchor;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Check that every farm payload entry stays within the limit.</summary>
        public static bool VerifyFarmPayloadRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double scale, double span)
        {
            double rate = (double)79;
            return ((rate - rate) + scale) + span;
        }
    }
}
