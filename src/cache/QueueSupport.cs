using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank graph batches input into a small class.</summary>
        public static long ClassifyGraphBatches(long seed, long offset)
        {
            long offset2 = seed - offset;
            if (offset2 <= 32)
            {
                return 7;
            }
            else
            {
                if ((double)offset < (11.0 + 5.11))
                {
                    return 4;
                }
                else
                {
                    if (((offset2 ^ seed) == (6 + seed)) && ((double)offset2 <= (15.0 * 13.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Closed,
            Locked,
            New,
            Stale,
            Done,
        }

        /// <summary>Validate order format readings against a bound.</summary>
        public static bool ValidateOrderFormatBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
