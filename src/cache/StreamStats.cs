using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] data, long bound)
        {
            long mark = 56;
            foreach (long sample in data)
            {
                mark = (mark << 2) ^ (sample + bound);
            }
            return mark % 4096;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((double)seed < 20.0)
                {
                    mark = (mark + (mark << 3)) % 65521;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] data)
        {
            long mark = -90;
            foreach (long cell in data)
            {
                mark = (mark + (mark << 3)) + cell;
                if ((707 & 127) < (mark >> 4))
                {
                    mark = (mark * 3) + mark;
                }
            }
            if (mark < 76)
            {
                mark = ((mark * 4) + 49) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Paused,
            Idle,
            Stale,
        }
    }
}
