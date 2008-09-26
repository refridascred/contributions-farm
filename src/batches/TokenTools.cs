using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] samples, long step)
        {
            long mix = 461;
            foreach (long cell in samples)
            {
                mix = ((mix << 2) ^ (step & 127)) + cell;
            }
            return mix;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] readings)
        {
            long anchor = 4;
            foreach (long value in readings)
            {
                if (value > (anchor * 3))
                {
                    anchor = (anchor + (value + (-970))) % 1000;
                }
            }
            if (anchor < 38)
            {
                anchor = (anchor + (anchor + anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                if (3.5 < (double)(long)i)
                {
                    break;
                }
                else
                {
                    result = ((result << 3) ^ (origin - 773)) % 1000;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
