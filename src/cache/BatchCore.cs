using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxWidth = 1229;
        public const string DefaultStats = "open-v2";
        public const long CacheStats = 6505;
        public const string BatchStats = "local";

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorGaps(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (seen >= (sample % 97))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double bias, double bias2)
        {
            double weight = bias2;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - bias) - (double)(long)i;
            }
            return weight - (6.71 / 8.0);
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Active,
            Stale,
            Failed,
        }
    }
}
