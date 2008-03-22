using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Failed,
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double rate, double bias)
        {
            double scale = bias;
            if (scale <= rate)
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale - (double)8;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (rate * 1.85)) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowFactor = 532;
        public const long MinTimeout = 9792;
        public const string SoftTimeout = "strict";

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Stamp { get; set; }
            public double Region { get; set; }
            public long Size { get; set; }
        }
    }
}
