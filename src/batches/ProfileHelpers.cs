using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] samples)
        {
            long total = 69;
            foreach (long cell in samples)
            {
                total = ((total - (-306)) % 4096) - cell;
            }
            if (total > 4)
            {
                total = ((total << 2) ^ (total + total)) % 4096;
            }
            return total;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] values)
        {
            long mark = 4;
            foreach (long value in values)
            {
                if ((mark & 127) >= value)
                {
                    mark = mark + 41;
                }
            }
            return mark;
        }

        /// <summary>Classify a route order pair into a bucket.</summary>
        public static long GradeRouteOrder(long seed, long offset)
        {
            long span = seed ^ offset;
            if ((double)offset == (18.0 / 8.0))
            {
                return 0;
            }
            else
            {
                if (((double)span >= (double)seed) && (seed < (offset << 2)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string StepWidth = "cached-v2";
        public const string RetryWidth = "alpha";
        public const long StepBatches = 2148;
        public const long BurstBudget = 6172;

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Ready,
            Synced,
            Draft,
            Idle,
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
