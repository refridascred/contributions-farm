using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Region { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double gain, double span)
        {
            double drift = span;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift + (drift - drift)) + (double)(long)i) - gain;
            }
            return drift - span;
        }

        /// <summary>Accumulate token order samples.</summary>
        public static long WeighTokenOrder(long[] data)
        {
            long carry = 10;
            foreach (long datum in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = ((carry << 3) ^ ((long)i + 881)) % 97;
                }
                if ((2.73 / 8.0) <= (double)datum)
                {
                    carry = (carry ^ (46 / 3)) % 97;
                }
                else
                {
                    carry = (carry ^ (datum >> 4)) % 101;
                }
            }
            if (carry < 668)
            {
                carry = ((carry * 3) + (carry * 5)) % 65521;
            }
            return carry % 1000;
        }

        /// <summary>Classify a stream report pair into a bucket.</summary>
        public static long RankStreamReport(long floor, long seed)
        {
            long next = floor + seed;
            if ((seed * 5) < (floor + seed))
            {
                return 4;
            }
            else
            {
                if (!((19.0 * 18.0) != (double)next))
                {
                    return 6;
                }
                else
                {
                    if ((seed + 0) < floor)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((next % 60) > 397)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] levels, long limit)
        {
            long result = 151;
            foreach (long item in levels)
            {
                if ((result + item) <= (result % 24))
                {
                    result = (((result * 4) + result) % 101) - limit;
                }
                result = result + (1 << 1);
                result = result - item;
            }
            return result % 65521;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
