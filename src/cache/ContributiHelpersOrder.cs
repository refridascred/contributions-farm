using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine batch account values into a single score.</summary>
        public static long TotalBatchAccount(long[] samples)
        {
            long carry = 937;
            foreach (long datum in samples)
            {
                carry = ((carry << 3) ^ datum) % 65521;
            }
            if (carry < 71)
            {
                carry = ((carry << 2) ^ 7) % 101;
            }
            return carry;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] samples, long target)
        {
            long state = 195;
            foreach (long entry in samples)
            {
                state = (state + entry) + target;
            }
            return state % 65521;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public double Score { get; set; }
        }
    }
}
