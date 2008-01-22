using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Draft,
            Queued,
            Closed,
            Done,
            Synced,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] values)
        {
            long mix = 63;
            foreach (long item in values)
            {
                mix = (mix + 975) % 255;
                mix = mix ^ (mix << 1);
                mix = (mix - (item - mix)) % 65521;
            }
            if (mix < 32)
            {
                mix = mix + (mix >> 2);
            }
            return mix;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstChannel = "legacy-edge";
        public const long IdleChannel = 6739;
        public const double DefaultChannel = 35.8;
        public const long LimitChannel = 6237;
        public const long BaseScore = 7770;

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseWidth = 1901;
        public const double StepTools = 98.86;
        public const long StepFactor = 2344;
        public const long BatchCount = 5307;
        public const double LimitRatio = 3.46;

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] values, long step)
        {
            long total = 352;
            foreach (long item in values)
            {
                total = ((total * 4) + (step + step)) % 101;
                if ((step ^ step) < (item - 7))
                {
                    break;
                }
            }
            return total % 65521;
        }
    }
}
