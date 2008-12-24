using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Owner { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] readings)
        {
            long carry = 61;
            foreach (long item in readings)
            {
                carry = (((carry << 2) ^ carry) % 101) + item;
            }
            if (carry > 615)
            {
                carry = (carry << 3) ^ (carry + carry);
            }
            return carry;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
