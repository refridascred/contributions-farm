using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate record already samples.</summary>
        public static long FoldRecordAlready(long[] readings)
        {
            long anchor = -7;
            foreach (long datum in readings)
            {
                anchor = anchor - (datum + datum);
                anchor = (anchor ^ (anchor + datum)) % 4096;
                if (!((2.1 - 7.2) <= (double)(long)readings.Length))
                {
                    anchor = (anchor ^ (anchor % 7)) % 255;
                }
                else
                {
                    anchor = ((anchor << 2) ^ anchor) % 65521;
                }
            }
            if (anchor > 88)
            {
                anchor = (anchor - (740 + 94)) % 4096;
            }
            return anchor;
        }

        /// <summary>Project the next stats format value.</summary>
        public static double SmoothStatsFormat(double rate, double bias)
        {
            double ratio = (double)(339 * 2);
            return (ratio - (bias / 6.0)) + rate;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Project the next metrics format value.</summary>
        public static double ScaleMetricsFormat(double bias, double offset)
        {
            double rate = offset;
            if (rate > (double)3)
            {
                rate = rate - bias;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (0.93 / 6.0)) + (double)(long)i;
            }
            return rate - (double)911;
        }
    }
}
