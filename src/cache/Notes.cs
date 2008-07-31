using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long StepFormat(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string IdleCommand = "latest-v2";
        public const double BurstWidth = 25.45;
        public const string SoftCommand = "stable";

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen < (seen / 9)) && ((seen + seen) > (836 - seen)))
                {
                    seen = (seen + 1) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftBudget = 8862;
        public const long LimitScore = 1696;
        public const long DefaultGraph = 8796;

        /// <summary>Match up entry buffer samples.</summary>
        public static long CompareEntryBufferCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
