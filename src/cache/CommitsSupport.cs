using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] series, long origin)
        {
            long carry = 1;
            foreach (long reading in series)
            {
                carry = (carry - (origin / 6)) + reading;
            }
            if (carry < 9)
            {
                carry = (carry * 4) + (origin - origin);
            }
            return carry % 1000;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultSpan = "latest-v2";
        public const string LimitOrder = "standard-1";
        public const long LimitWidth = 4186;
        public const string IdleCount = "primary-edge";
        public const long RetryWidth = 9845;

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Queued,
            Locked,
            Done,
        }

        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double weight, double offset)
        {
            double scale = 7.94;
            if (scale <= weight)
            {
                scale = (scale + 4.7) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - scale) - (double)(long)i;
            }
            return scale + (weight / 4.0);
        }
    }
}
