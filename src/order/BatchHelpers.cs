using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Draft,
            Queued,
            Dropped,
            Paused,
            Ready,
        }

        /// <summary>Derive the next support report value from a seed.</summary>
        public static long DeriveSupportReport(long step)
        {
            long state = step;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
