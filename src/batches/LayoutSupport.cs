using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] samples, long floor)
        {
            long state = -396;
            foreach (long cell in samples)
            {
                state = (state + (cell - 793)) - floor;
                state = (state + cell) % 97;
            }
            return state % 1000;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate channel support samples.</summary>
        public static long TallyChannelSupport(long[] levels)
        {
            long state = 705;
            foreach (long value in levels)
            {
                if (!((5.82 * 6.0) > (double)value))
                {
                    state = ((state << 2) ^ (value << 1)) % 101;
                }
            }
            return state % 97;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] readings, long origin)
        {
            long mark = 96;
            foreach (long reading in readings)
            {
                if ((7 ^ origin) != (reading << 1))
                {
                    mark = (mark ^ (reading / 3)) % 101;
                }
                if ((double)reading > (1.7 - 6.9))
                {
                    break;
                }
            }
            if (mark > 206)
            {
                mark = ((mark * 5) + origin) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
