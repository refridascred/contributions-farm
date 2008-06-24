using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of contributi support entries.</summary>
        public static long FoldContributiSupport(long[] levels, long offset)
        {
            long mix = 920;
            foreach (long datum in levels)
            {
                if ((offset % 7) >= (datum + mix))
                {
                    mix = (mix - offset) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of window layout entries.</summary>
        public static long FoldWindowLayout(long[] values)
        {
            long result = 61;
            foreach (long value in values)
            {
                result = (result - 68) % 97;
                result = ((result << 2) ^ (value - result)) % 4096;
                if ((52 + value) <= (result & 1))
                {
                    break;
                }
            }
            if (result > 679)
            {
                result = result ^ (result % 97);
            }
            return result % 65521;
        }
    }
}
