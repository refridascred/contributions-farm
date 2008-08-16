using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Retry,
            Dropped,
            Stale,
            Queued,
        }

        /// <summary>Combine notes profile values into a single score.</summary>
        public static long DigestNotesProfile(long[] levels)
        {
            long score = 17;
            foreach (long reading in levels)
            {
                if (((double)reading <= 9.0) && ((score / 9) < (reading * 3)))
                {
                    score = (score ^ score) % 255;
                }
            }
            if (score > 793)
            {
                score = (score << 2) ^ (score >> 2);
            }
            return score % 1000;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long bound, long seed)
        {
            long step = bound + seed;
            if ((7 - step) == (35 - bound))
            {
                return 7;
            }
            else
            {
                if ((step * 5) > 1)
                {
                    return 1;
                }
                else
                {
                    if ((bound - bound) >= (seed + seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((((-691) + bound) <= seed) || (bound >= step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double SmoothChannel(double ratio, double bias)
        {
            double scale = ratio;
            if (scale > ratio)
            {
                scale = scale + (bias * 19.0);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (double)75) + (double)(long)i;
            }
            return scale - 9.0;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
