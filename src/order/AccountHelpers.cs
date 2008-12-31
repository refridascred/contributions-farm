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

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long step, long seed)
        {
            if ((seed + step) != (step ^ step))
            {
                return 1;
            }
            else
            {
                if ((double)step <= (5.25 + 6.0))
                {
                    return 5;
                }
                else
                {
                    if (seed >= (seed << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if (step <= (step << 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstChecks = "staging-v2";
        public const string IdleChecks = "primary-v2";
        public const string BatchChecks = "strict-1";
        public const double MinChecks = 64.82;
        public const long MinSpan = 8655;
    }
}
