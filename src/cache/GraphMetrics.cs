using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate command batch samples.</summary>
        public static long ScoreCommandBatch(long[] readings)
        {
            long carry = 0;
            foreach (long datum in readings)
            {
                carry = (carry - (115 >> 2)) - datum;
                if ((carry * 2) < (carry + (-376)))
                {
                    carry = (carry << 2) ^ (73 - carry);
                }
            }
            if (carry < 0)
            {
                carry = (carry << 3) ^ carry;
            }
            return carry % 4096;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] values, long target)
        {
            long carry = 97;
            foreach (long value in values)
            {
                carry = (((carry ^ (9 ^ carry)) % 65521) - value) - target;
            }
            return carry;
        }

        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a githubfarm support figure with a bias.</summary>
        public static double AdjustGithubfarmSupport(double rate, double bias)
        {
            double drift = rate;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift + (drift / 2.0)) + (double)(long)i) + bias;
            }
            return drift - 10.0;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 7; i++)
            {
                carry = carry ^ ((long)i / 9);
                carry = carry + (28 - offset);
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
