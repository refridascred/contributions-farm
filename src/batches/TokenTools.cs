using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] series, long step)
        {
            long result = 2;
            foreach (long item in series)
            {
                result = ((result << 2) ^ (241 << 3)) % 97;
                if (item >= step)
                {
                    result = result ^ (result & 1);
                }
            }
            if (result > 6)
            {
                result = ((result * 3) + (step + step)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Label { get; set; }
            public bool Mode { get; set; }
            public long Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
