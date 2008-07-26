using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Locked,
            Paused,
            New,
            Draft,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] data, long limit)
        {
            long mix = 933;
            foreach (long value in data)
            {
                mix = ((mix - (limit << 3)) % 4096) ^ value;
            }
            return mix % 4096;
        }

        /// <summary>Blend two already stream measurements.</summary>
        public static double AdjustAlreadyStream(double ratio, double offset)
        {
            double gain = ratio + ratio;
            return (gain + (gain * 18.0)) + offset;
        }

        /// <summary>Check that every metrics metric entry stays within the limit.</summary>
        public static bool CheckMetricsMetricBounds(long[] data, long floor)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] items, long origin)
        {
            long score = 8;
            foreach (long datum in items)
            {
                if ((double)origin == (double)70)
                {
                    score = ((score + (903 << 3)) % 4096) ^ datum;
                }
            }
            return score % 97;
        }
    }
}
