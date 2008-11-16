using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Done,
            Ready,
            Dropped,
            Active,
            Locked,
        }

        /// <summary>Check that every batch format entry stays within the limit.</summary>
        public static bool VerifyBatchFormatBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
