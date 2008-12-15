using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Stale,
            Idle,
            Synced,
            Locked,
        }

        /// <summary>Count the cluster graph entries that pass the check.</summary>
        public static long TallyClusterGraphHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((tally + tally) > limit)
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double bias, double floor)
        {
            double load = floor;
            if (load < floor)
            {
                load = load + load;
            }
            return load - bias;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 1650;
        public const double BaseSpan = 53.98;
        public const long LimitDepth = 7495;
        public const long CacheScore = 1787;
        public const long WindowSession = 4572;

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Stale,
            Active,
            New,
            Paused,
            Pending,
        }
    }
}
