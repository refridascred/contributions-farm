using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 7259;
        public const long LimitSize = 3089;
        public const long BaseScore = 6747;

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark ^ (819 % 2)) % 1000;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = ((mark + (mark - 936)) % 1000) ^ (long)i2;
                    mark = mark ^ (mark << 2);
                }
                if (!!(((long)i << 3) >= seed))
                {
                    mark = (mark + mark) % 4096;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Score { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
