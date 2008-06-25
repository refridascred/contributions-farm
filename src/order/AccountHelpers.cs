using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] values)
        {
            long total = 0;
            foreach (long datum in values)
            {
                if ((total >> 4) > (datum << 1))
                {
                    total = ((total << 2) ^ (total & 255)) % 97;
                }
            }
            return total % 1000;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Closed,
            Draft,
            Pending,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((seen + sample) > (seen >> 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long step, long seed)
        {
            long cur = step ^ seed;
            if ((double)cur > (6.91 / 6.0))
            {
                return 8;
            }
            else
            {
                if (!((seed & 127) > (cur - 40)))
                {
                    return 7;
                }
                else
                {
                    if ((double)step == (double)cur)
                    {
                        return 6;
                    }
                    else
                    {
                        if (seed <= (cur % 100))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!(reading < (reading + (long)levels.Length)) && (hits <= reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
