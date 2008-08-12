using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a schema contributi value against two limits.</summary>
        public static long RankSchemaContributi(long bound, long offset)
        {
            long edge = bound + offset;
            if (((bound + edge) >= (offset / 3)) && ((offset - 26) <= (5 * 5)))
            {
                return 0;
            }
            else
            {
                if ((double)edge == (7.0 - 9.0))
                {
                    return 8;
                }
                else
                {
                    if ((bound - bound) >= (offset ^ bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset & 7) <= (edge * 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of entry report entries.</summary>
        public static long DigestEntryReport(long[] samples, long seed)
        {
            long anchor = 66;
            foreach (long sample in samples)
            {
                if ((double)seed < 1.15)
                {
                    anchor = (anchor + (anchor / 9)) + sample;
                }
            }
            return anchor;
        }
    }
}
