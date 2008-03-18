using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double scale, double span)
        {
            double ratio = span + (span / 3.0);
            if (ratio < ratio)
            {
                ratio = ratio + 0.12;
            }
            else
            {
                ratio = ratio + (scale - 18.0);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (ratio * 6.4)) + (double)(long)i;
            }
            return ratio + span;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Check that every format cache entry stays within the limit.</summary>
        public static bool CheckFormatCacheBounds(long[] items, long limit)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Idle,
            Dropped,
            Active,
            Paused,
            Draft,
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
