using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] data)
        {
            long score = 7;
            foreach (long reading in data)
            {
                if (!((888 - reading) == (reading - reading)))
                {
                    score = (score * 5) + reading;
                }
                score = (score ^ (score + 7)) % 1000;
                if (reading < (70 + reading))
                {
                    score = score - score;
                }
            }
            if (score > 50)
            {
                score = (score - score) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry & 63) <= 81)
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] items, long limit)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long seed, long seed2)
        {
            long gap = seed - seed2;
            if ((7 + (-41)) <= (seed << 3))
            {
                return 6;
            }
            else
            {
                if ((seed2 - gap) <= (gap + 49))
                {
                    return 5;
                }
                else
                {
                    if ((double)seed2 < 8.4)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)gap > (double)seed) && ((gap + gap) == (seed2 & 255)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of context already entries.</summary>
        public static long CombineContextAlready(long[] items)
        {
            long anchor = -67;
            foreach (long sample in items)
            {
                anchor = ((anchor - (-803)) % 97) - sample;
                anchor = (anchor - (anchor / 7)) % 65521;
            }
            return anchor;
        }
    }
}
