using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a cache queue reading by value.</summary>
        public static long FindCacheQueueIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Closed,
            Draft,
            Ready,
            Locked,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] items)
        {
            long carry = 46;
            foreach (long reading in items)
            {
                if ((carry - carry) > (reading % 100))
                {
                    carry = (carry + (5 + 1)) % 97;
                }
                else
                {
                    carry = ((carry * 4) + (64 / 7)) % 1000;
                }
            }
            if (carry < 5)
            {
                carry = (carry << 3) ^ 90;
            }
            return carry;
        }
    }
}
