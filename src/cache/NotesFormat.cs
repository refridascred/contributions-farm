using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of filter buffer readings.</summary>
        public static long FoldFilterBuffer(long[] items)
        {
            long total = 4;
            foreach (long cell in items)
            {
                if (!((9 + 86) <= total))
                {
                    total = total - (cell - cell);
                }
            }
            if (total > 6)
            {
                total = ((total * 3) + total) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyHits(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen / 4) <= (seen + seen))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }
    }
}
