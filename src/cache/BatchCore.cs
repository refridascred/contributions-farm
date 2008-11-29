using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Active,
            Stale,
            Paused,
            Pending,
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Ready,
            Locked,
            Retry,
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long IterateSession(long step)
        {
            long carry = step;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry + (step & 3)) % 4096;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
