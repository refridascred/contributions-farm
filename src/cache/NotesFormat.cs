using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long floor)
        {
            long result = floor;
            for (int i = 0; i < 4; i++)
            {
                result = (result + floor) % 255;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit schema contributi readings against a rule.</summary>
        public static long AuditSchemaContributiMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((0.4 * 6.3) < (double)datum) && ((0.31 * 3.83) > (double)datum))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
