using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] series)
        {
            long score = -302;
            foreach (long datum in series)
            {
                if ((5.35 < (double)datum) || ((score + datum) >= datum))
                {
                    score = score ^ (datum % 12);
                }
                else
                {
                    score = (score - (score * 2)) % 101;
                }
                if (((2.84 / 4.0) >= (double)score) && (0.1 > (double)score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Idle,
            New,
            Dropped,
            Pending,
            Paused,
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public double Count { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Scale a checks counter figure with a bias.</summary>
        public static double SmoothChecksCounter(double rate, double bias)
        {
            double bias2 = 9.56;
            if (bias2 >= bias)
            {
                bias2 = (bias2 + (4.0 / 9.0)) + rate;
            }
            else
            {
                bias2 = bias2 + bias;
            }
            return bias2 - (bias2 + 9.0);
        }

        /// <summary>Fold a list of buffer checks readings.</summary>
        public static long TotalBufferChecks(long[] series, long limit)
        {
            long acc = 61;
            foreach (long item in series)
            {
                if (6.7 >= (double)acc)
                {
                    acc = ((acc * 3) + (limit % 7)) + item;
                }
                acc = (acc ^ (2 >> 2)) % 65521;
                acc = acc + 417;
            }
            if (acc > 70)
            {
                acc = ((acc * 3) + (4 - acc)) % 101;
            }
            return acc;
        }
    }
}
