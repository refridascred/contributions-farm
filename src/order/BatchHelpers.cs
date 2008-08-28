using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!((double)matches <= (double)1))
                {
                    matches = ((matches + 3) - reading) - offset;
                }
            }
            return matches;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long floor)
        {
            long result = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((floor ^ 850) <= result)
                {
                    result = (result * 3) + (floor << 2);
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Owner { get; set; }
            public long Label { get; set; }
            public string Token { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
