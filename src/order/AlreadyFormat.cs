using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double SmoothChannel(double ratio, double span)
        {
            double bias = ratio;
            if (bias >= (double)1)
            {
                bias = (bias - ratio) - span;
            }
            return bias - (double)158;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Total { get; set; } = "";
            public long Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Audit channel route readings against a rule.</summary>
        public static long AuditChannelRouteHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!(((double)matches <= (1.3 / 7.0)) && (matches >= (step + (long)readings.Length))))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of layout schema readings.</summary>
        public static long OverlapLayoutSchemaCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double DefaultCount = 88.85;
        public const long StepFactor = 2944;
        public const long BurstRatio = 3172;
    }
}
