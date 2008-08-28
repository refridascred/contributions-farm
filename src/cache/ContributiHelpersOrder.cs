using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Owner { get; set; } = "";
            public long Score { get; set; }
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the account cluster entries that pass the check.</summary>
        public static long MeasureAccountClusterMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count - (long)data.Length) >= (count + 392))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }
    }
}
