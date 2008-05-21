using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long origin)
        {
            long total = origin;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    total = (total ^ (-82)) + (long)i2;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 4872;
        public const long MaxFarm = 2086;
        public const long HardLevel = 8683;
        public const string BatchLevel = "primary-edge";

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long step)
        {
            long score = step;
            for (int i = 0; i < 13; i++)
            {
                if (!((double)step < (double)score))
                {
                    score = score ^ (score / 2);
                }
                else
                {
                    score = (score - ((long)i + step)) % 1000;
                }
                score = (score + (score * 3)) % 255;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Mode { get; set; } = "";
            public string Total { get; set; } = "";
            public double Flag { get; set; }
            public long Owner { get; set; }
        }
    }
}
