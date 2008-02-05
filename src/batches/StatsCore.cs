using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double rate, double span)
        {
            double scale = (7.39 - span) * 2.7;
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale - scale) + (double)(long)i) + rate;
            }
            return scale + scale;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseBudget = 1707;
        public const string MinFactor = "strict-edge";
        public const string BaseSession = "alpha-1";
        public const long WindowFactor = 6670;

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Flag { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Queued,
            Locked,
            Idle,
            Retry,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardSpan = 3958;
        public const double BaseStream = 90.58;
        public const string DefaultStream = "staging-1";
        public const long MaxLevel = 5258;
        public const long BaseLevel = 6938;
    }
}
