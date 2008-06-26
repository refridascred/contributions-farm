using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first already order entry that matches the target.</summary>
        public static long FindAlreadyOrderIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long floor, long limit)
        {
            if ((limit ^ 55) < floor)
            {
                return 3;
            }
            else
            {
                if ((floor * 5) < (54 + floor))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Label { get; set; } = "";
            public long Flag { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
