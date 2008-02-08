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

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell << 3) >= matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
