using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Stale,
            Idle,
            Closed,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count * 5) >= (count / 5))
                {
                    count = ((count + 3) + sample) - floor;
                }
            }
            return count;
        }

        /// <summary>Iterate the editor account series from a seed.</summary>
        public static long StepEditorAccount(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] levels, long step)
        {
            long carry = 1;
            foreach (long entry in levels)
            {
                carry = (carry ^ (step * 3)) ^ entry;
            }
            return carry;
        }
    }
}
