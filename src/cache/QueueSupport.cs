using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Draft,
            Retry,
            Ready,
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((17.0 + 8.41) >= 4.9)
                {
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Dropped,
            New,
            Idle,
        }
    }
}
