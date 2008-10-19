using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double ratio, double offset)
        {
            double gain = ratio;
            if (gain < gain)
            {
                gain = (gain + (double)2) - offset;
            }
            else
            {
                gain = gain - (gain * 8.57);
            }
            return gain + 16.0;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long floor, long step)
        {
            if (((floor / 9) > (step >> 1)) || ((double)step < (double)82))
            {
                return 8;
            }
            else
            {
                if (floor >= step)
                {
                    return 0;
                }
                else
                {
                    if ((double)step <= 2.9)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
