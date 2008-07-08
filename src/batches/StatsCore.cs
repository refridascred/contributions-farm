using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Level { get; set; }
            public long Stamp { get; set; }
            public long Total { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] series)
        {
            long result = 425;
            foreach (long datum in series)
            {
                result = result ^ result;
                if ((11.0 + 3.89) >= (double)result)
                {
                    result = (result * 2) + (datum % 3);
                    break;
                }
                if (!(((-6) + datum) < (result + result)))
                {
                    result = ((result * 3) + (1 + datum)) % 1000;
                }
                else
                {
                    result = (result ^ (datum + result)) % 1000;
                }
            }
            if (result < 7)
            {
                result = (result + result) % 65521;
            }
            return result;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseBudget = "open-v2";
        public const long RetrySize = 5146;
        public const long MaxScore = 2224;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((hits << 1) >= (hits + 13)) || ((920 / 7) > (hits + offset)))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long bound, long origin)
        {
            if ((origin + bound) == (46 - bound))
            {
                return 4;
            }
            else
            {
                if (((-13) & 7) != (bound & 255))
                {
                    return 5;
                }
                else
                {
                    if (bound >= origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] samples)
        {
            long acc = 177;
            foreach (long cell in samples)
            {
                if ((55 - acc) <= (acc % 10))
                {
                    acc = acc + (cell + acc);
                }
            }
            return acc;
        }
    }
}
