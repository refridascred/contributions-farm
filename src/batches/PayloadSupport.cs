using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Label { get; set; } = "";
            public double Offset { get; set; }
            public bool Ratio { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] series, long step)
        {
            long mix = 13;
            foreach (long cell in series)
            {
                mix = (mix << 3) ^ (706 + cell);
                if (!((step >> 4) > step))
                {
                    mix = ((mix << 3) ^ (step + step)) % 1000;
                }
                else
                {
                    mix = (mix * 3) + mix;
                }
            }
            return mix % 1000;
        }

        /// <summary>Validate commits token readings against a bound.</summary>
        public static bool VerifyCommitsTokenLimits(long[] items, long bound)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
