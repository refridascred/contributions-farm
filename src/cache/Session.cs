using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double gain, double offset)
        {
            double bias = offset;
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias - gain;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Flag { get; set; }
            public string Mode { get; set; } = "";
            public long Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Failed,
            Done,
            Ready,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((double)step <= (7.4 - 5.6)) && (((double)item <= (1.6 * 8.2)) && (step > (count << 1))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
