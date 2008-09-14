using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] values)
        {
            long mix = 85;
            foreach (long value in values)
            {
                mix = (mix + (mix ^ mix)) % 4096;
                if ((880 % 97) != (value ^ value))
                {
                    break;
                }
            }
            if (mix < 194)
            {
                mix = (mix ^ mix) % 65521;
            }
            return mix % 65521;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (matches < (seed + 6))
                {
                    matches = (matches + 1) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Flag { get; set; }
            public double Count { get; set; }
            public string Mode { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
