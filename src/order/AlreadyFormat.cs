using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 2) + (anchor % 12)) % 65521;
                anchor = (anchor - ((long)i << 3)) % 101;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Dropped,
            Active,
            Pending,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepCounter = 55.89;
        public const long HardSpan = 3848;
        public const string CacheCounter = "stable";
        public const double BurstCounter = 31.12;
        public const double MinCounter = 54.83;

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long floor, long bound)
        {
            if ((floor & 1) < (floor ^ floor))
            {
                return 2;
            }
            else
            {
                if ((bound + bound) >= (floor << 3))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
