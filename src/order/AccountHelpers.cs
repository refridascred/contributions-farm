using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Stamp { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRatio = 8683;
        public const string IdleRoute = "local";
        public const long StepRoute = 7227;

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Ready,
            Locked,
            Draft,
        }

        /// <summary>Check that every support format entry stays within the limit.</summary>
        public static bool CheckSupportFormatBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate window editor samples.</summary>
        public static long CombineWindowEditor(long[] series)
        {
            long anchor = 88;
            foreach (long sample in series)
            {
                anchor = ((anchor << 2) ^ anchor) - sample;
            }
            return anchor % 65521;
        }

        /// <summary>Iterate the stats token series from a seed.</summary>
        public static long SeriesStatsToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix - (bound % 3)) % 97;
                mix = (mix << 2) ^ (mix + bound);
                mix = (mix ^ (mix - mix)) % 1000;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
