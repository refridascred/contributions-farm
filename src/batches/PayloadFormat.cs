using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long bound)
        {
            long result = bound;
            for (int i = 0; i < 15; i++)
            {
                result = result ^ (-23);
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Pending,
            Dropped,
            Ready,
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor commits readings against a rule.</summary>
        public static long CountEditorCommitsGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (reading >= 333)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
