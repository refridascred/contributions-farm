using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Weight { get; set; }
            public string Label { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Grade a stats contributi value against two limits.</summary>
        public static long RankStatsContributi(long floor, long target)
        {
            if ((target + 117) < 65)
            {
                return 1;
            }
            else
            {
                if (2.2 > (double)target)
                {
                    return 6;
                }
                else
                {
                    if ((double)target > (6.4 - 0.84))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((8 - target) <= (target + 1))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
