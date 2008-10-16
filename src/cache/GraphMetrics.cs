using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double scale, double offset)
        {
            double ratio = 2.27;
            if (ratio <= scale)
            {
                ratio = (ratio - (double)7) - offset;
            }
            return ratio + scale;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] samples)
        {
            long carry = 9;
            foreach (long datum in samples)
            {
                if (!((double)carry == (4.0 * 5.0)))
                {
                    carry = carry - 5;
                }
                else
                {
                    carry = (carry - datum) % 101;
                }
            }
            if (carry > 80)
            {
                carry = ((carry << 3) ^ (carry % 16)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double gain, double span)
        {
            double mean = (double)((-572) % 5);
            if (mean >= (20.0 / 7.0))
            {
                mean = ((mean - (double)981) - gain) - span;
            }
            return mean - mean;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 5485;
        public const double BurstRatio = 96.45;
        public const long RetryAlready = 4309;

        /// <summary>Find the first format stats entry that matches the target.</summary>
        public static long SeekFormatStatsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
