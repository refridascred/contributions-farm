using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Ratio { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] data)
        {
            long mark = 2;
            foreach (long cell in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    mark = ((mark + cell) % 65521) + (long)i;
                    mark = (mark ^ cell) % 1000;
                }
                if ((cell - mark) < (mark << 1))
                {
                    mark = (mark + (cell + cell)) % 4096;
                }
                else
                {
                    mark = mark - (mark / 5);
                }
            }
            if (mark > 367)
            {
                mark = mark + (mark % 2);
            }
            return mark % 4096;
        }
    }
}
