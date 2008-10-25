using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)item == (8.0 + 8.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] levels)
        {
            long mix = 11;
            foreach (long entry in levels)
            {
                if (!((entry / 6) > mix))
                {
                    mix = mix ^ entry;
                }
            }
            return mix;
        }
    }
}
