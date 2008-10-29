using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a editor session sample.</summary>
        public static long FindEditorSessionIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long offset)
        {
            long result = offset;
            for (int i = 0; i < 5; i++)
            {
                result = (result - ((-67) & 255)) % 1000;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Count { get; set; }
            public long Label { get; set; }
            public string Region { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
