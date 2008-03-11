using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 5102;
        public const double CacheSession = 34.88;
        public const long WindowSession = 3304;
        public const double MaxDepth = 31.34;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (seen >= ((-41) % 64))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (target >= (datum % 5))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Paused,
            Idle,
            Draft,
            Active,
        }

        /// <summary>Audit tools command readings against a rule.</summary>
        public static long CountToolsCommandGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (matches < (matches - matches))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 9; i++)
            {
                sum = sum ^ offset;
                sum = sum - 21;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
