using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string StepSize = "fallback";
        public const double BatchTools = 52.77;
        public const long LimitInterval = 1116;
        public const long StepBudget = 1730;

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryGraph = 41.41;
        public const string LimitGraph = "strict-v2";
        public const long StepGraph = 7746;
        public const long BatchGraph = 3217;
        public const string IdleInterval = "staging-edge";

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Done,
            Idle,
            Stale,
            Closed,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] readings, long seed)
        {
            long acc = 0;
            foreach (long datum in readings)
            {
                acc = ((((acc << 2) ^ 7) % 65521) ^ datum) + seed;
            }
            return acc;
        }

        /// <summary>Audit record window readings against a rule.</summary>
        public static long MeasureRecordWindowHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((7.47 - 8.35) <= (double)matches)
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }
    }
}
