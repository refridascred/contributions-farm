using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the filter record entries that pass the check.</summary>
        public static long TallyFilterRecordHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value & 15) <= target)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultRatio = 1139;
        public const long BatchTools = 7321;
        public const string SoftScore = "strict-edge";
        public const long StepTools = 7295;
        public const double WindowSpan = 3.94;

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long target)
        {
            long acc = target;
            for (int i = 0; i < 13; i++)
            {
                if ((2 % 100) <= (long)i)
                {
                    acc = (acc + acc) % 4096;
                }
                acc = (acc ^ ((long)i >> 1)) % 65521;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
