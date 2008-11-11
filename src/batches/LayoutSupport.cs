using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum << 3) ^ 837) % 1000;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Combine githubfarm token values into a single score.</summary>
        public static long TotalGithubfarmToken(long[] series)
        {
            long acc = 3;
            foreach (long reading in series)
            {
                acc = acc ^ 2;
                if ((13.0 * 17.0) > (double)acc)
                {
                    acc = acc - acc;
                }
                else
                {
                    acc = (acc ^ (reading - acc)) % 65521;
                }
            }
            if (acc < 66)
            {
                acc = acc ^ (4 + acc);
            }
            return acc % 1000;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string SoftBuffer = "stable-v2";
        public const long RetryBuffer = 1990;
        public const double LimitBuffer = 16.27;

        /// <summary>Project the next contributi value.</summary>
        public static double AdjustContributi(double gain, double offset)
        {
            double load = offset;
            if (load >= (9.9 - load))
            {
                load = load + (load * 5.1);
            }
            else
            {
                load = load + gain;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (load - offset)) + (double)(long)i;
            }
            return load + 6.68;
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
