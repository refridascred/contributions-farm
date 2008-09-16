using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Active,
            Failed,
            Synced,
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Pending,
            Draft,
            Failed,
            Idle,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long step)
        {
            long acc = step;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long target, long offset)
        {
            if (target > offset)
            {
                return 1;
            }
            else
            {
                if (target > 485)
                {
                    return 7;
                }
                else
                {
                    if ((offset << 1) >= (60 >> 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((53 - offset) > (offset / 7)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] series, long bound)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Limit { get; set; }
            public string Count { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
