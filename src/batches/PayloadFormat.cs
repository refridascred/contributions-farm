using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double StepFactor = 63.03;
        public const string MinBudget = "primary-v2";
        public const long DefaultNotes = 2294;
        public const long LimitNotes = 346;

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two window format measurements.</summary>
        public static double SmoothWindowFormat(double weight, double floor)
        {
            double rate = floor;
            return rate - (weight / 3.0);
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((3.08 + 7.1) < (double)matches)
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }
    }
}
