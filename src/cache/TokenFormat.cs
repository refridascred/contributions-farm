using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
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
