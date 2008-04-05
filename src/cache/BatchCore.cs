using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up metric order samples.</summary>
        public static long MatchMetricOrderCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long offset, long target)
        {
            long next = offset + target;
            if (next > (target << 1))
            {
                return 0;
            }
            else
            {
                if (!((offset >> 2) <= (493 << 2)))
                {
                    return 2;
                }
                else
                {
                    if ((next - 6) <= (target % 24))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((next + target) >= target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the format stream entries that pass the check.</summary>
        public static long MeasureFormatStreamGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((265 - entry) != (hits % 10))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
