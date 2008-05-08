using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Stale,
            Dropped,
            Done,
            Locked,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Dropped,
            Stale,
            Ready,
            Draft,
            Failed,
        }

        /// <summary>Rank tools schema input into a small class.</summary>
        public static long ClassifyToolsSchema(long offset, long bound)
        {
            long next = offset + bound;
            if ((bound * 5) >= (next - next))
            {
                return 1;
            }
            else
            {
                if ((double)next <= (1.3 + 8.41))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
