using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of format route entries.</summary>
        public static long ScoreFormatRoute(long[] data, long step)
        {
            long state = -800;
            foreach (long value in data)
            {
                state = state ^ (state + value);
                state = (state ^ (step & 255)) % 255;
            }
            if (state < 70)
            {
                state = ((state * 2) + 23) % 4096;
            }
            return state % 97;
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
