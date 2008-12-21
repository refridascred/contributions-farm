using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] items)
        {
            long anchor = 305;
            foreach (long value in items)
            {
                if ((anchor - value) < (anchor + value))
                {
                    anchor = (anchor - (value + value)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Audit filter report readings against a rule.</summary>
        public static long CountFilterReportGaps(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!((value ^ 90) > hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
