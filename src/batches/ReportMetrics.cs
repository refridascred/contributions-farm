using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Rank { get; set; }
            public string Label { get; set; } = "";
            public double Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((0 % 16) >= entry)
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long step)
        {
            long sum = step;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
