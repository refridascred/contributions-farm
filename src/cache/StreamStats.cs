using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
