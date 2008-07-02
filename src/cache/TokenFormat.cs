using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Label { get; set; }
            public string Count { get; set; } = "";
            public bool Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 5; i++)
            {
                mark = mark ^ (origin * 5);
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] series, long limit)
        {
            long state = 947;
            foreach (long sample in series)
            {
                if ((double)limit != (6.0 + 1.5))
                {
                    state = (state + (limit ^ sample)) % 255;
                }
            }
            return state;
        }
    }
}
