using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitBudget = "open-1";
        public const long BatchDepth = 4829;
        public const double IdleFactor = 61.01;

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Ready,
            Active,
            Done,
            Retry,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] readings)
        {
            long mark = 480;
            foreach (long reading in readings)
            {
                mark = (mark - mark) % 4096;
                if (((9.9 - 3.3) > (double)mark) && (reading <= (reading - mark)))
                {
                    mark = (mark << 2) ^ (mark - 3);
                    mark = mark + (mark ^ reading);
                    continue;
                }
                if (((-21) / 3) <= (mark + mark))
                {
                    mark = ((mark << 2) ^ (reading << 1)) % 4096;
                }
            }
            return mark;
        }
    }
}
