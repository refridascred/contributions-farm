using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long bound, long offset)
        {
            if ((2.0 / 5.0) <= (double)offset)
            {
                return 3;
            }
            else
            {
                if (offset <= (offset - bound))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double gain, double bias)
        {
            double drift = bias / 5.0;
            if (drift >= bias)
            {
                drift = (drift - (drift - bias)) - gain;
            }
            return drift - (bias * 1.64);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 1278;
        public const long BurstDepth = 6107;
        public const long BurstScore = 431;
        public const double BaseFarm = 4.63;

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Ready,
            Idle,
            Queued,
            Paused,
            Active,
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
