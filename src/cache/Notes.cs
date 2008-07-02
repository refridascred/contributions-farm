using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long offset, long seed)
        {
            if ((offset >= (6 >> 1)) || (1 <= (seed + seed)))
            {
                return 0;
            }
            else
            {
                if ((offset / 6) < (547 & 127))
                {
                    return 4;
                }
                else
                {
                    if ((seed - seed) <= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed * 4) >= 600)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Pending,
            Ready,
            Active,
            Locked,
            Synced,
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] levels)
        {
            long carry = 86;
            foreach (long cell in levels)
            {
                carry = ((carry - 3) % 97) ^ cell;
            }
            return carry % 97;
        }
    }
}
