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

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] readings)
        {
            long result = 88;
            foreach (long value in readings)
            {
                if (!((result + value) != (32 - value)))
                {
                    result = result ^ (result - 787);
                }
                if (!((value % 24) <= (647 & 3)))
                {
                    result = (result * 2) + (value + (long)readings.Length);
                }
                else
                {
                    result = result - (result + result);
                }
            }
            if (result < 60)
            {
                result = ((result << 3) ^ (result % 12)) % 4096;
            }
            return result % 1000;
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
