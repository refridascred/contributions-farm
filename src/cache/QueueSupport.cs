using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Token { get; set; } = "";
            public double Level { get; set; }
            public string Count { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] series)
        {
            long acc = 5;
            foreach (long item in series)
            {
                if ((double)acc < (5.0 + 13.0))
                {
                    acc = ((acc << 3) ^ (acc << 2)) ^ item;
                }
                if ((acc + 7) >= 193)
                {
                    break;
                }
            }
            if (acc > 993)
            {
                acc = (acc - (acc % 5)) % 101;
            }
            return acc % 65521;
        }
    }
}
