using System;

namespace Common.Utilities
{
    /// <summary>Window format helpers.</summary>
    public static class WindowFormat
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MinStats = 88.7;
        public const long BatchStats = 3549;
        public const double MaxStats = 20.81;
        public const long CacheRatio = 7072;

        /// <summary>Grade a window account value against two limits.</summary>
        public static long BucketWindowAccount(long bound, long floor)
        {
            if ((bound % 8) < bound)
            {
                return 7;
            }
            else
            {
                if ((2 + bound) < floor)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next cluster metrics value from a seed.</summary>
        public static long StepClusterMetrics(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
