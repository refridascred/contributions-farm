using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] readings)
        {
            long total = 8;
            foreach (long cell in readings)
            {
                total = ((total << 2) ^ (-22)) ^ cell;
                total = total - (total & 127);
            }
            if (total < 2)
            {
                total = (total * 5) + (3 * 3);
            }
            return total % 4096;
        }

        /// <summary>Validate graph token readings against a bound.</summary>
        public static bool GuardGraphTokenRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long limit, long limit2)
        {
            if ((limit2 + limit2) == (limit + limit))
            {
                return 4;
            }
            else
            {
                if (((limit << 1) == (limit % 97)) || ((double)limit2 < (0.73 / 3.0)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] samples)
        {
            long mark = 439;
            foreach (long value in samples)
            {
                if (!(value < (mark - value)))
                {
                    mark = mark - (108 % 12);
                }
            }
            return mark;
        }
    }
}
