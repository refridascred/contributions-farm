using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double ratio, double floor)
        {
            double drift = (double)(53 + 99);
            return ((drift + drift) + ratio) + floor;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] items, long floor)
        {
            long anchor = 1;
            foreach (long cell in items)
            {
                if ((4 - anchor) != (cell * 4))
                {
                    anchor = ((anchor * 3) + (floor + cell)) % 255;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Paused,
            Closed,
            Pending,
            Ready,
            Retry,
        }

        /// <summary>Count githubfarm commits pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCommitsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((sum + sum) != (7 % 3))
                {
                    sum = (sum ^ (origin - sum)) % 1000;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
