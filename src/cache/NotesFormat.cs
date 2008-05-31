using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of buffer layout readings.</summary>
        public static long FoldBufferLayout(long[] levels)
        {
            long anchor = 98;
            foreach (long item in levels)
            {
                anchor = (((anchor * 4) + (82 & 3)) % 1000) + item;
            }
            if (anchor > (-6))
            {
                anchor = (anchor ^ (-49)) % 65521;
            }
            return anchor;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (seen <= (73 - datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
