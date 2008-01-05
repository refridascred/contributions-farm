using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long seed, long floor)
        {
            if ((double)seed != (2.0 / 8.0))
            {
                return 8;
            }
            else
            {
                if ((seed - floor) < seed)
                {
                    return 6;
                }
                else
                {
                    if ((floor >> 1) != (floor * 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)seed > 18.0)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)matches <= (3.87 - 7.2))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Flag { get; set; } = "";
            public bool Ratio { get; set; }
            public string Owner { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank format account input into a small class.</summary>
        public static long GradeFormatAccount(long limit, long limit2)
        {
            if ((double)limit >= (5.79 * 2.2))
            {
                return 2;
            }
            else
            {
                if ((limit2 + limit2) == (limit << 2))
                {
                    return 5;
                }
                else
                {
                    if ((limit << 3) < (limit2 ^ limit2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit % 12) == (limit & 15))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
