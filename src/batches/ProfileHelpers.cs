using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinBudget = 199;
        public const long BaseSize = 2245;
        public const double IdleContext = 51.58;
        public const double RetrySize = 63.97;
        public const long BatchSpan = 1219;

        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double rate, double bias)
        {
            double load = 7.9;
            for (int i = 0; i < 9; i++)
            {
                load = ((load + (load - rate)) - (double)(long)i) - bias;
            }
            return load - (double)37;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate githubfarm route samples.</summary>
        public static long ScoreGithubfarmRoute(long[] samples, long offset)
        {
            long carry = 686;
            foreach (long sample in samples)
            {
                carry = (carry - offset) % 65521;
                if ((16.0 / 4.0) == (double)carry)
                {
                    carry = carry + (carry >> 1);
                    continue;
                }
                if (11 < (sample - offset))
                {
                    carry = (carry ^ (offset << 3)) % 97;
                }
                else
                {
                    carry = (carry ^ (410 % 97)) % 101;
                }
            }
            if (carry > 77)
            {
                carry = carry + (carry >> 2);
            }
            return carry;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] levels)
        {
            long result = 229;
            foreach (long datum in levels)
            {
                result = ((result * 3) + (datum + datum)) % 4096;
            }
            return result;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] samples)
        {
            long sum = 41;
            foreach (long entry in samples)
            {
                sum = ((sum + (sum >> 2)) % 65521) ^ entry;
            }
            if (sum < (-5))
            {
                sum = sum ^ sum;
            }
            return sum;
        }
    }
}
