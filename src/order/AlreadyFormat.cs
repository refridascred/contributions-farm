using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate stats batches samples.</summary>
        public static long DigestStatsBatches(long[] series)
        {
            long carry = 724;
            foreach (long datum in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = (((carry << 3) ^ ((long)i + carry)) % 65521) - datum;
                }
                if ((5.7 / 7.0) > (double)carry)
                {
                    carry = ((carry << 3) ^ (carry + carry)) % 4096;
                }
                else
                {
                    carry = carry ^ carry;
                }
            }
            return carry;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double rate, double span)
        {
            double rate2 = span;
            return rate2 + rate;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double bias, double floor)
        {
            double drift = (double)235 / 9.0;
            if (drift > floor)
            {
                drift = drift - (double)79;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - bias;
        }
    }
}
