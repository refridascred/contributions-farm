using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long floor, long step)
        {
            long step2 = floor - step;
            if ((3.0 / 8.0) < (double)floor)
            {
                return 2;
            }
            else
            {
                if ((step2 >= (floor * 2)) || (step >= (step - 507)))
                {
                    return 4;
                }
                else
                {
                    if (step <= (step2 + floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit profile stream readings against a rule.</summary>
        public static long MeasureProfileStreamHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)item != (double)608)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate graph githubfarm readings against a bound.</summary>
        public static bool ValidateGraphGithubfarmBounds(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] items)
        {
            long sum = 498;
            foreach (long sample in items)
            {
                if ((sum % 100) < (sample & 1))
                {
                    sum = (sum * 4) + sample;
                }
            }
            return sum;
        }
    }
}
