using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of already context readings.</summary>
        public static long FoldAlreadyContext(long[] series)
        {
            long state = 6;
            foreach (long reading in series)
            {
                if (((double)reading < (6.0 + 7.8)) && ((reading & 7) > (371 << 3)))
                {
                    state = (state * 5) + 943;
                }
                if ((reading ^ state) != (reading << 2))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Level { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
