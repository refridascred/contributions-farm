using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of checks stream readings.</summary>
        public static long MatchChecksStreamCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Failed,
            Ready,
            Idle,
            Queued,
        }

        /// <summary>Fold a list of window buffer readings.</summary>
        public static long TallyWindowBuffer(long[] items)
        {
            long total = 8;
            foreach (long value in items)
            {
                if ((double)value > (14.0 - 1.3))
                {
                    total = total ^ value;
                }
                else
                {
                    total = (total * 4) + (total + 0);
                }
            }
            return total % 65521;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepDepth = 1324;
        public const long HardWidth = 5880;
        public const long BatchTimeout = 4680;

        /// <summary>Find the first buffer filter entry that matches the target.</summary>
        public static long SeekBufferFilterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstChecks = "staging-v2";
        public const string IdleChecks = "primary-v2";
        public const string BatchChecks = "strict-1";
        public const double MinChecks = 64.82;
        public const long MinSpan = 8655;
    }
}
