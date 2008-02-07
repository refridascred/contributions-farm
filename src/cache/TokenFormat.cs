using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value - value) < (matches - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long step, long target)
        {
            if (!((target % 3) <= target))
            {
                return 0;
            }
            else
            {
                if ((step - step) <= (target + 83))
                {
                    return 3;
                }
                else
                {
                    if (target >= (step >> 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchSize = 633;
        public const long SoftFormat = 6814;
        public const long StepFormat = 1346;
        public const double LimitFormat = 5.15;
    }
}
