using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    acc = ((acc << 2) ^ (acc >> 5)) + (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank batches cluster input into a small class.</summary>
        public static long ClassifyBatchesCluster(long origin, long target)
        {
            long prev = origin ^ target;
            if ((origin * 5) < (prev + target))
            {
                return 4;
            }
            else
            {
                if (!(target <= prev))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
