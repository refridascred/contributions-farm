using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long origin, long offset)
        {
            if ((offset % 60) >= (1 / 9))
            {
                return 2;
            }
            else
            {
                if ((offset - 708) >= (52 >> 5))
                {
                    return 8;
                }
                else
                {
                    if (((double)offset <= (16.0 + 9.1)) && ((offset - origin) != (5 & 31)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit counter queue readings against a rule.</summary>
        public static long AuditCounterQueueOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((76 - seed) >= (tally >> 2)) || ((110 - sample) < (55 >> 3)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Synced,
            New,
            Draft,
            Stale,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)step >= (0.29 / 6.0))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Idle,
            Active,
            Pending,
        }

        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double scale, double floor)
        {
            double rate = scale;
            if (rate <= (double)(-7))
            {
                rate = rate - (double)0;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (floor + rate)) + (double)(long)i;
            }
            return rate - scale;
        }
    }
}
