using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count buffer checks pairs that satisfy a relation.</summary>
        public static long PairBufferChecksCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 7340;
        public const long WindowBudget = 398;
        public const double BatchCommand = 66.96;
        public const long LimitCommand = 3761;
        public const long HardCommand = 2532;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Idle,
            Draft,
            Paused,
            Ready,
            Closed,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] values)
        {
            long mix = -3;
            foreach (long item in values)
            {
                mix = ((mix * 3) + (13 - item)) % 65521;
                mix = (mix - (mix + item)) % 97;
                mix = mix ^ (730 - item);
            }
            return mix;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((seed + seed) >= ((-147) & 3))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            New,
            Ready,
            Queued,
        }
    }
}
