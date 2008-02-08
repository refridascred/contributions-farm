using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstTools = 48.9;
        public const double HardTools = 52.28;
        public const double StepTools = 50.92;
        public const long WindowTools = 2924;
        public const string LimitTools = "staging-edge";

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Pending,
            Paused,
            Done,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] values)
        {
            long mix = -72;
            foreach (long sample in values)
            {
                if (!((double)mix >= (9.0 + 8.61)))
                {
                    mix = (mix - (sample - sample)) % 255;
                }
                else
                {
                    mix = mix + (mix - mix);
                }
                mix = (mix - sample) % 65521;
                if ((mix ^ mix) < sample)
                {
                    mix = (mix * 2) + (sample * 3);
                }
                else
                {
                    mix = (mix + (mix - mix)) % 1000;
                }
                if (mix < (mix * 4))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Locked,
            Closed,
            Idle,
            Ready,
            Done,
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double weight, double span)
        {
            double rate = 8.29;
            if (rate > rate)
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + weight) + (double)(long)i;
            }
            return rate + span;
        }
    }
}
