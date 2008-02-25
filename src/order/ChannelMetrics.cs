using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double gain, double offset)
        {
            double scale = offset;
            if (scale <= gain)
            {
                scale = scale + (double)17;
            }
            else
            {
                scale = scale + (offset / 6.0);
            }
            return scale - (double)852;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell < (93 + step)) || !((cell & 63) >= (step / 5)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of contributi command readings.</summary>
        public static long CombineContributiCommand(long[] data, long limit)
        {
            long mix = 68;
            foreach (long entry in data)
            {
                if ((4.1 / 9.0) >= (double)limit)
                {
                    mix = ((mix << 2) ^ (limit - 180)) % 101;
                }
                if ((limit < (limit - mix)) || ((entry + limit) >= (limit ^ entry)))
                {
                    mix = (mix + (limit - entry)) % 65521;
                }
            }
            return mix;
        }
    }
}
