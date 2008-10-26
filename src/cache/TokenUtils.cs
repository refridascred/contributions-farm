using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 1745;
        public const double IdleWidth = 67.29;
        public const long HardAlready = 3189;

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] values)
        {
            long anchor = 1;
            foreach (long cell in values)
            {
                anchor = anchor + (cell + cell);
                if (((cell >> 2) > (1 % 16)) || ((double)anchor < (8.0 / 7.0)))
                {
                    anchor = anchor - cell;
                }
            }
            if (anchor < 425)
            {
                anchor = (anchor + (anchor % 2)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
