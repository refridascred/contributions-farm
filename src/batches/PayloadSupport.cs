using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long PairFarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Active,
            New,
            Queued,
        }
    }
}
