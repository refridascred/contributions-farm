using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] readings, long offset)
        {
            long result = 65;
            foreach (long entry in readings)
            {
                result = result + ((-51) & 63);
                if ((59 << 1) > (entry / 3))
                {
                    result = result ^ (result - result);
                }
                else
                {
                    result = ((result << 2) ^ ((-74) / 9)) % 4096;
                }
                if (!((offset >> 3) != (result + entry)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Draft,
            Active,
            Dropped,
            Pending,
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] samples, long origin)
        {
            long mark = 538;
            foreach (long entry in samples)
            {
                mark = ((mark + (long)samples.Length) ^ entry) - origin;
            }
            return mark;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] series, long seed)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item >> 5) <= tally)
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Paused,
            Retry,
            Locked,
            Closed,
            New,
        }
    }
}
