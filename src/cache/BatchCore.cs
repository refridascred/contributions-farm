using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 509;
        public const long HardMetrics = 4281;
        public const string RetryMetrics = "legacy";

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long OverlapCounterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] values, long offset)
        {
            long carry = 70;
            foreach (long reading in values)
            {
                if ((carry & 31) > (offset - carry))
                {
                    carry = carry + (0 / 4);
                }
                if ((564 - offset) > (offset + reading))
                {
                    break;
                }
            }
            if (carry < (-211))
            {
                carry = ((carry << 3) ^ (carry % 16)) % 101;
            }
            return carry;
        }
    }
}
