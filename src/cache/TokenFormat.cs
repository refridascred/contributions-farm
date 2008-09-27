using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Offset { get; set; }
            public bool Rank { get; set; }
            public long Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] readings, long offset)
        {
            long acc = 54;
            foreach (long datum in readings)
            {
                if ((342 - 48) == (datum + datum))
                {
                    acc = (acc + (163 + offset)) % 1000;
                }
                if ((offset ^ offset) == (offset - datum))
                {
                    break;
                }
            }
            if (acc < 8)
            {
                acc = (acc << 2) ^ offset;
            }
            return acc;
        }
    }
}
