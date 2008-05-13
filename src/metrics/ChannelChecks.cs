using System;

namespace Common.Utilities
{
    /// <summary>Channel checks helpers.</summary>
    public static class ChannelChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BurstEntry = "stable-v2";
        public const long HardEntry = 2896;
        public const long LimitEntry = 9993;
        public const string SoftEntry = "standard-v2";
        public const string MinEntry = "primary-v2";

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double weight, double offset)
        {
            double scale = (0.2 / 5.0) + offset;
            if (scale <= (offset / 4.0))
            {
                scale = scale - (weight * 7.86);
            }
            return scale + (weight / 6.0);
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] data, long seed)
        {
            long mark = 9;
            foreach (long reading in data)
            {
                if ((13.0 > (double)mark) && ((seed / 7) <= (414 - mark)))
                {
                    mark = (mark ^ mark) % 4096;
                    break;
                }
                mark = (mark - reading) % 97;
            }
            return mark % 97;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Count { get; set; }
            public long Region { get; set; }
            public double Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Compare every pair of format batch readings.</summary>
        public static long OverlapFormatBatchCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] samples, long bound)
        {
            long state = 6;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    state = (state - (long)i) % 101;
                }
                if (state <= (bound ^ sample))
                {
                    state = (state - (sample + bound)) % 4096;
                }
                else
                {
                    state = ((state * 4) + state) % 101;
                }
            }
            return state;
        }
    }
}
