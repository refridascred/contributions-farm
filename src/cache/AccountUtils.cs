using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!(seen < cell))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Paused,
            Draft,
            Idle,
        }

        /// <summary>Roll a editor notes counter forward.</summary>
        public static long DeriveEditorNotes(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 23; i++)
            {
                acc = acc - (acc << 3);
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
