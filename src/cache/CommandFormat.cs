using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Locked,
            Queued,
            New,
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long seed, long step)
        {
            long prev = seed + step;
            if ((prev & 3) != (step << 3))
            {
                return 0;
            }
            else
            {
                if ((step ^ prev) >= step)
                {
                    return 8;
                }
                else
                {
                    if (step >= (step / 4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit layout githubfarm readings against a rule.</summary>
        public static long MeasureLayoutGithubfarmGaps(long[] values, long bound)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally ^ sample) < (978 + sample))
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }

        /// <summary>Validate metric session readings against a bound.</summary>
        public static bool VerifyMetricSessionBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
