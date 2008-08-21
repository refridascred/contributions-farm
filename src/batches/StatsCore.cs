using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double ratio, double floor)
        {
            double bias = 2.5;
            return bias + (ratio + floor);
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] readings)
        {
            long anchor = 777;
            foreach (long reading in readings)
            {
                if ((reading / 2) <= anchor)
                {
                    anchor = ((anchor << 3) ^ 55) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate checks channel samples.</summary>
        public static long ScoreChecksChannel(long[] readings, long target)
        {
            long mix = 87;
            foreach (long datum in readings)
            {
                if (target > (1 & 255))
                {
                    mix = (mix ^ (target ^ datum)) % 101;
                }
                else
                {
                    mix = (mix * 5) + (target - target);
                }
                if ((double)(long)readings.Length >= (double)datum)
                {
                    break;
                }
            }
            if (mix > 3)
            {
                mix = (mix * 4) + (23 + mix);
            }
            return mix;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 4622;
        public const long IdleCounter = 699;
        public const double WindowCounter = 30.15;
        public const long SoftSpan = 6454;

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double scale, double offset)
        {
            double rate = scale;
            if (rate < (double)99)
            {
                rate = (rate + (double)90) - offset;
            }
            else
            {
                rate = rate + (rate + rate);
            }
            return rate - (double)(-727);
        }
    }
}
