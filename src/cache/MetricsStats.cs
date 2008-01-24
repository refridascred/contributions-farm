using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double ratio, double offset)
        {
            double load = ratio;
            return (load + (double)7) + offset;
        }

        /// <summary>Roll a report channel counter forward.</summary>
        public static long RollReportChannel(long step)
        {
            long mix = step;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix << 3) ^ (mix & 255)) % 101;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double gain, double span)
        {
            double bias = gain;
            if (bias < (span + gain))
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias - (double)3;
            }
            return bias - (4.4 * 11.0);
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] items)
        {
            long score = 295;
            foreach (long item in items)
            {
                if ((3.0 / 7.0) == (double)item)
                {
                    score = ((score << 3) ^ (item & 1)) % 255;
                }
                if ((double)item == (17.0 * 3.89))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Locked,
            Retry,
            Queued,
        }
    }
}
