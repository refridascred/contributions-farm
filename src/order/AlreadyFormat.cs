using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string RetryProfile = "primary-v2";
        public const double BurstProfile = 21.82;
        public const long IdleLevel = 287;

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 156;
        public const string StepWidth = "open-1";
        public const double MaxRatio = 95.59;

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] samples)
        {
            long result = 3;
            foreach (long item in samples)
            {
                if ((double)result <= (double)item)
                {
                    result = result ^ item;
                }
            }
            if (result > (-374))
            {
                result = ((result * 4) + result) % 255;
            }
            return result;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Region { get; set; }
            public long Weight { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
        }
    }
}
