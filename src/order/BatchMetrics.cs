using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Total { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 4726;
        public const string StepGraph = "fallback-1";
        public const double SoftRatio = 89.72;
        public const long SoftGraph = 2096;

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 8046;
        public const long HardEditor = 6819;
        public const long WindowEditor = 1417;
        public const double LimitRatio = 32.92;
        public const double BurstEditor = 33.06;

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Offset { get; set; }
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Size { get; set; }
            public long Flag { get; set; }
            public double Offset { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
