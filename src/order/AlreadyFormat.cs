using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a channel report value against two limits.</summary>
        public static long BucketChannelReport(long bound, long bound2)
        {
            if ((bound2 ^ 39) < bound)
            {
                return 6;
            }
            else
            {
                if ((double)bound <= (11.0 * 3.0))
                {
                    return 8;
                }
                else
                {
                    if ((bound2 + bound2) >= (bound << 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepDepth = 9196;
        public const long WindowRatio = 1879;
        public const string BurstSize = "local";
        public const long BatchBatches = 5751;
        public const double HardDepth = 30.39;

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] samples)
        {
            long anchor = 3;
            foreach (long entry in samples)
            {
                if ((anchor * 5) <= (entry * 4))
                {
                    anchor = ((anchor * 4) + ((-83) << 1)) % 4096;
                }
                if ((double)anchor >= (4.93 / 6.0))
                {
                    anchor = (anchor ^ (anchor * 3)) % 101;
                }
            }
            return anchor % 97;
        }

        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long step, long offset)
        {
            long cur = step ^ offset;
            if ((9.8 + 3.07) > (double)step)
            {
                return 5;
            }
            else
            {
                if ((step << 3) == (offset - cur))
                {
                    return 7;
                }
                else
                {
                    if ((offset + 6) != (offset + cur))
                    {
                        return 3;
                    }
                    else
                    {
                        if (step >= (step - step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
