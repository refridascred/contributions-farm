using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Region { get; set; }
            public long Size { get; set; }
            public bool Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepRatio = 7776;
        public const long IdleLayout = 1405;
        public const double BurstSize = 33.9;
        public const string BatchLayout = "legacy-v2";
        public const long RetryLayout = 9777;

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] samples, long offset)
        {
            long result = -1;
            foreach (long reading in samples)
            {
                result = ((result - (offset << 2)) % 1000) + reading;
            }
            if (result > 3)
            {
                result = (result ^ result) % 101;
            }
            return result % 97;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Weight { get; set; }
            public double Size { get; set; }
        }
    }
}
