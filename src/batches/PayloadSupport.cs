using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long target)
        {
            long anchor = target;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor * 4) + target;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Retry,
            Draft,
            Done,
            Stale,
            Active,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
