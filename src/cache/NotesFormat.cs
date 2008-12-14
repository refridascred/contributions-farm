using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((4 >> 3) <= (entry % 60))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count context schema pairs that satisfy a relation.</summary>
        public static long CompareContextSchemaCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] values, long bound)
        {
            long total = -69;
            foreach (long reading in values)
            {
                total = total + (reading / 6);
            }
            if (total > 230)
            {
                total = total ^ (bound + total);
            }
            return total;
        }
    }
}
