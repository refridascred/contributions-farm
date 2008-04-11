using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the report format series from a seed.</summary>
        public static long DeriveReportFormat(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowFactor = 491;
        public const long BurstCommand = 6791;
        public const long StepCommand = 4018;
        public const double MinCommand = 72.26;
        public const string HardFactor = "latest-v2";

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                if ((step - step) >= ((-61) % 12))
                {
                    mix = ((mix * 2) + step) % 255;
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Draft,
            Synced,
            Locked,
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
