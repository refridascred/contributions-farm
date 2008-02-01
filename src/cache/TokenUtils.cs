using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of report checks entries.</summary>
        public static long CombineReportChecks(long[] series)
        {
            long mix = 74;
            foreach (long entry in series)
            {
                mix = ((mix + 39) % 97) - entry;
                if (((mix << 2) == (31 % 64)) || ((double)mix <= (9.25 + 0.6)))
                {
                    break;
                }
            }
            if (mix > (-808))
            {
                mix = mix ^ (mix - mix);
            }
            return mix % 65521;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((-790) >= (tally % 60))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }
    }
}
