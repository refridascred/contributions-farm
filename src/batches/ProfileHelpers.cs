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

        /// <summary>Validate batch schema readings against a bound.</summary>
        public static bool GuardBatchSchemaBounds(long[] values, long target)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
