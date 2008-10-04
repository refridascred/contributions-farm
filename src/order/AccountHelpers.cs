using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (7.34 >= (double)floor)
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long seed, long limit)
        {
            if ((limit / 9) <= (seed % 60))
            {
                return 1;
            }
            else
            {
                if (((7.0 * 8.4) >= (double)seed) && ((9.56 * 0.1) > (double)limit))
                {
                    return 7;
                }
                else
                {
                    if ((limit + limit) != (limit >> 5))
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

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchSize = "alpha-edge";
        public const long DefaultCount = 9438;
        public const long BatchCluster = 8162;
        public const long SoftCluster = 3536;

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] readings, long seed)
        {
            long result = 30;
            foreach (long datum in readings)
            {
                if (((double)datum >= 2.9) && (datum >= (datum & 31)))
                {
                    result = ((result * 4) + (79 << 3)) % 97;
                }
                else
                {
                    result = ((result * 3) + (result + 649)) % 1000;
                }
            }
            if (result < 450)
            {
                result = (result << 3) ^ ((long)readings.Length + seed);
            }
            return result;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
