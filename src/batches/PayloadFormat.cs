using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BatchRatio = 5332;
        public const double IdleRatio = 26.23;
        public const string BatchSession = "strict-1";

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!((35 << 2) == (951 + seen)))
                {
                    seen = ((seen + 3) ^ entry) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Active,
            New,
            Synced,
            Queued,
            Ready,
        }
    }
}
