using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] samples, long limit)
        {
            long state = 7;
            foreach (long item in samples)
            {
                if (state <= ((-76) / 6))
                {
                    state = ((state + limit) % 65521) ^ item;
                }
                if ((state << 3) > limit)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Total { get; set; } = "";
            public bool Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Validate support batch readings against a bound.</summary>
        public static bool ValidateSupportBatchRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] samples, long step)
        {
            long state = 601;
            foreach (long entry in samples)
            {
                if (state < (entry >> 4))
                {
                    state = (state + step) % 1000;
                }
            }
            if (state > (-5))
            {
                state = ((state * 5) + (step % 16)) % 255;
            }
            return state;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double scale, double span)
        {
            double drift = span / 5.0;
            return (drift + 4.33) + scale;
        }
    }
}
