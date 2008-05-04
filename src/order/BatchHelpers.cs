using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long step, long floor)
        {
            if ((floor - step) <= (step << 1))
            {
                return 6;
            }
            else
            {
                if ((double)step != (double)floor)
                {
                    return 1;
                }
                else
                {
                    if (step >= floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if (3.0 < (double)step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Label { get; set; }
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }
    }
}
