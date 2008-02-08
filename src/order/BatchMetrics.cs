using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Limit { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardWidth = 6020;
        public const double CacheCommits = 58.43;
        public const double SoftCommits = 20.81;

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 9931;
        public const double HardProfile = 14.97;
        public const long DefaultProfile = 5987;
        public const long BatchSize = 541;

        /// <summary>Scale a schema route figure with a bias.</summary>
        public static double BlendSchemaRoute(double bias, double offset)
        {
            double bias2 = bias + (double)79;
            if (bias2 > 11.0)
            {
                bias2 = (bias2 - (bias / 9.0)) + offset;
            }
            return bias2 - bias;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample + seen) < (step << 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a schema stream reading by value.</summary>
        public static long SeekSchemaStreamIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
