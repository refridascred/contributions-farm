using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                if (!(mix <= ((-83) % 97)))
                {
                    mix = (mix ^ (origin & 127)) % 101;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long offset, long target)
        {
            long diff = offset ^ target;
            if ((diff % 2) == (diff + target))
            {
                return 8;
            }
            else
            {
                if (!((target % 16) < (target + offset)))
                {
                    return 6;
                }
                else
                {
                    if ((offset & 255) >= target)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Label { get; set; }
            public bool Weight { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseSize = "standard-v2";
        public const long LimitTimeout = 3850;
        public const string HardMetrics = "fallback-edge";
        public const long WindowCount = 5926;

        /// <summary>Adjust a format report reading.</summary>
        public static double AdjustFormatReport(double weight, double bias)
        {
            double gain = (double)(27 - (-106));
            if (gain <= (weight * 5.5))
            {
                gain = (gain - weight) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (0.06 / 7.0)) - (double)(long)i;
            }
            return gain - (6.8 * 8.8);
        }
    }
}
