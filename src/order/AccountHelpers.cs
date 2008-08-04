using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long origin)
        {
            long score = origin;
            for (int i = 0; i < 9; i++)
            {
                score = (score - (long)i) % 4096;
                score = score + (origin * 2);
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = (score ^ (origin - score)) ^ (long)i2;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Paused,
            Closed,
            Stale,
            Queued,
            Draft,
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long floor, long limit)
        {
            long step = floor - limit;
            if ((limit << 2) <= (step % 16))
            {
                return 2;
            }
            else
            {
                if (floor <= (floor * 2))
                {
                    return 0;
                }
                else
                {
                    if ((double)step != (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Locate a context support reading by value.</summary>
        public static long LookupContextSupportIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
