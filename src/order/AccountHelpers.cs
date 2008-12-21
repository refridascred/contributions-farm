using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up filter format samples.</summary>
        public static long CompareFilterFormatCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Size { get; set; }
            public long Total { get; set; }
            public bool Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 9687;
        public const long MaxCount = 2622;
        public const double HardWidth = 58.97;

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long bound, long target)
        {
            long slot = bound - target;
            if ((double)target >= (5.84 / 2.0))
            {
                return 4;
            }
            else
            {
                if ((1.29 * 8.2) < (double)slot)
                {
                    return 3;
                }
                else
                {
                    if ((bound * 3) < (target / 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((slot << 3) < (target % 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorBounds(long[] readings, long limit)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Queued,
            Dropped,
            Draft,
            Idle,
        }
    }
}
