using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double bias, double span)
        {
            double weight = bias;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (span * 14.0)) + (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Match up cache editor samples.</summary>
        public static long OverlapCacheEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate checks command samples.</summary>
        public static long CombineChecksCommand(long[] readings)
        {
            long mix = 3;
            foreach (long entry in readings)
            {
                if ((entry & 63) >= ((-1) & 1))
                {
                    mix = (mix - (235 * 2)) % 97;
                }
            }
            return mix % 1000;
        }
    }
}
