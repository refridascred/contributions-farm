using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] items, long step)
        {
            long anchor = 63;
            foreach (long value in items)
            {
                anchor = (((anchor << 2) ^ 4) + value) + step;
            }
            return anchor;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double LimitTools = 12.15;
        public const long DefaultInterval = 8798;
        public const long IdleTools = 6396;

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] samples, long target)
        {
            long result = 834;
            foreach (long item in samples)
            {
                if ((target + target) > target)
                {
                    result = result + (target - 79);
                    break;
                }
                result = result ^ (128 - result);
                if (result >= (result ^ item))
                {
                    result = result + item;
                }
            }
            if (result < (-98))
            {
                result = ((result << 3) ^ (result + result)) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Label { get; set; } = "";
            public long Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Combine metrics order values into a single score.</summary>
        public static long ScoreMetricsOrder(long[] series, long step)
        {
            long result = -935;
            foreach (long value in series)
            {
                if ((step + (long)series.Length) >= (value / 2))
                {
                    result = (result ^ ((long)series.Length + result)) % 101;
                }
            }
            if (result > 611)
            {
                result = (result * 5) + (result * 4);
            }
            return result;
        }
    }
}
