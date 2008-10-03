using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 2080;
        public const string BatchWidth = "strict";
        public const long DefaultScore = 7747;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((((cell % 60) > (cell ^ cell)) && (((long)data.Length + 841) != (cell & 31))) || ((double)cell >= (3.74 * 1.84)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Queued,
            Active,
            Closed,
        }
    }
}
