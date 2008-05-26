using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] readings, long step)
        {
            long mix = 221;
            foreach (long entry in readings)
            {
                mix = ((mix << 2) ^ entry) - step;
            }
            return mix;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Offset { get; set; }
            public string Limit { get; set; } = "";
            public bool Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Scale a schema tools figure with a bias.</summary>
        public static double ScaleSchemaTools(double gain, double bias)
        {
            double gain2 = (double)(59 & 31);
            return ((gain2 - (double)6) + gain) + bias;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((step * 5) > 11)
                {
                    count = (count + 3) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 5352;
        public const double SoftFactor = 87.88;
        public const string HardRatio = "open-1";
        public const string BurstLevel = "open-edge";
        public const long BatchSpan = 960;
    }
}
