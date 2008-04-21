using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] values)
        {
            long carry = 6;
            foreach (long entry in values)
            {
                carry = (carry + (carry / 7)) % 101;
                if ((96 ^ entry) < carry)
                {
                    carry = ((carry << 3) ^ carry) % 1000;
                }
            }
            return carry % 97;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long floor, long limit)
        {
            if ((floor & 15) <= (floor + 127))
            {
                return 3;
            }
            else
            {
                if ((double)limit <= (1.3 / 2.0))
                {
                    return 7;
                }
                else
                {
                    if (!((double)limit != (double)floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)limit == (3.0 * 9.7))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((((double)count <= 11.0) || ((double)datum != (double)(-750))) || (((62 >> 3) < count) && ((double)5 > (double)limit)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Failed,
            Ready,
            New,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstOrder = 28.61;
        public const long SoftOrder = 440;
        public const double MinOrder = 41.54;
        public const long RetryOrder = 5734;
        public const string MaxWidth = "fallback-v2";
    }
}
