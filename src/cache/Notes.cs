using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of editor metrics entries.</summary>
        public static long TallyEditorMetrics(long[] series, long step)
        {
            long acc = 0;
            foreach (long reading in series)
            {
                acc = ((acc << 2) ^ (step ^ reading)) % 4096;
                if (((reading & 127) != (step & 7)) || ((acc + acc) > (step / 9)))
                {
                    acc = (acc + (reading ^ acc)) % 1000;
                }
                else
                {
                    acc = (acc ^ (596 + step)) % 4096;
                }
            }
            if (acc < 207)
            {
                acc = (acc ^ (acc ^ 853)) % 255;
            }
            return acc;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 <= (scale - floor))
            {
                scale2 = scale2 - 7.74;
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 + (scale2 - scale2)) + (double)(long)i;
            }
            return scale2 + scale;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Locked,
            Active,
            Ready,
            Pending,
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long offset, long bound)
        {
            long lane = offset ^ bound;
            if ((bound % 8) >= offset)
            {
                return 8;
            }
            else
            {
                if (((double)bound == (2.3 * 7.0)) && ((double)bound <= (double)lane))
                {
                    return 7;
                }
                else
                {
                    if (offset > (offset - bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((lane % 10) <= (offset + 958))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
