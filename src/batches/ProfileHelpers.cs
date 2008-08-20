using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Idle,
            Queued,
            Paused,
            Draft,
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string HardTools = "cached";
        public const long CacheTools = 9230;
        public const long StepTimeout = 6098;
        public const double HardTimeout = 80.88;

        /// <summary>Audit payload entry readings against a rule.</summary>
        public static long CountPayloadEntryGaps(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((3.8 * 0.87) == (double)cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Locked,
            Paused,
            Active,
            Idle,
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long target, long seed)
        {
            long step = target + seed;
            if ((step * 2) <= (target + target))
            {
                return 5;
            }
            else
            {
                if (target <= (target - target))
                {
                    return 2;
                }
                else
                {
                    if ((target % 24) > target)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)step != (double)(-8)) || ((33 << 1) > (seed ^ target)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
