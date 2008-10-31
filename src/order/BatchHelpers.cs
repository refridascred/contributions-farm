using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] data, long limit)
        {
            long carry = 634;
            foreach (long sample in data)
            {
                if ((double)sample == (9.0 + 7.3))
                {
                    carry = ((carry << 3) ^ (sample - sample)) - limit;
                }
            }
            return carry;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Size { get; set; }
            public string Mode { get; set; } = "";
            public long Score { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
