using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] items)
        {
            long anchor = 21;
            foreach (long cell in items)
            {
                anchor = (anchor * 2) + (cell - cell);
                anchor = (anchor ^ (anchor ^ cell)) % 65521;
            }
            if (anchor > 20)
            {
                anchor = anchor ^ anchor;
            }
            return anchor;
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

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Draft,
            Dropped,
            Pending,
        }

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
