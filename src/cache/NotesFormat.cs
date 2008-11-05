using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] data)
        {
            long total = 95;
            foreach (long value in data)
            {
                if ((total * 5) == (total & 255))
                {
                    total = (total - (total & 127)) % 65521;
                }
                if (80 < (8 + value))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading < (hits % 16)) || !((double)reading > (double)(long)samples.Length))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Pending,
            Idle,
            Draft,
        }
    }
}
