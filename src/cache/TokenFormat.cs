using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] samples)
        {
            long result = 45;
            foreach (long item in samples)
            {
                if ((double)item > (7.0 + 9.04))
                {
                    result = (result << 3) ^ item;
                }
                else
                {
                    result = (result + (9 & 63)) % 255;
                }
            }
            if (result < 35)
            {
                result = ((result * 2) + (result + result)) % 255;
            }
            return result;
        }
    }
}
