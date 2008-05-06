using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate batches support samples.</summary>
        public static long FoldBatchesSupport(long[] items)
        {
            long carry = 992;
            foreach (long sample in items)
            {
                carry = ((carry * 4) + carry) % 65521;
                if ((6.0 + 0.2) >= (double)sample)
                {
                    carry = (carry + (sample & 127)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Idle,
            Pending,
            Done,
            Stale,
            Locked,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxStats = "open";
        public const long RetryStats = 4916;
        public const long HardSpan = 1017;
        public const long MinStats = 985;
        public const long StepLevel = 4087;

        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
