using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of counter schema readings.</summary>
        public static long WeighCounterSchema(long[] samples, long bound)
        {
            long mark = 76;
            foreach (long cell in samples)
            {
                mark = mark ^ (cell + bound);
                if (((long)samples.Length & 63) >= (bound - bound))
                {
                    mark = mark - (bound - bound);
                }
                else
                {
                    mark = ((mark * 5) + mark) % 97;
                }
            }
            return mark;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmRange(long[] data, long bound)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many batch farm samples are out of range.</summary>
        public static long AuditBatchFarmMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((item >> 3) > (matches * 3)) && ((item / 7) == (item / 2)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                if (893 >= (origin + origin))
                {
                    mark = (mark + mark) % 1000;
                    break;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
