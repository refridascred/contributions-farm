using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((sum * 5) < (long)i)
                {
                    sum = sum - (1 << 3);
                    sum = (sum << 2) ^ 837;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double bias, double span)
        {
            double bias2 = span + (double)1;
            if (bias2 > bias2)
            {
                bias2 = (bias2 + (double)3) + bias;
            }
            else
            {
                bias2 = bias2 + (double)(-9);
            }
            return bias2 + bias2;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public string Weight { get; set; } = "";
            public bool Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] items, long bound)
        {
            long anchor = 286;
            foreach (long cell in items)
            {
                if (!((cell / 3) >= (anchor + bound)))
                {
                    anchor = (anchor - anchor) % 65521;
                }
                if ((6 + 41) == ((long)items.Length ^ bound))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
