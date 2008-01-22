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

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
