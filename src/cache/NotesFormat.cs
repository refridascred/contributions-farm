using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionGaps(long[] values, long step)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((double)hits <= 2.3) || ((step << 2) < (step / 9)))
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 4999;
        public const double WindowSize = 31.35;
        public const string BurstBudget = "strict-edge";
    }
}
