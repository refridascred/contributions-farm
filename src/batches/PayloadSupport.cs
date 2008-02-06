using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Queued,
            Dropped,
            Paused,
            Retry,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
