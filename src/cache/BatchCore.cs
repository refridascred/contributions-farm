using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long limit)
        {
            long total = limit;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    total = (total - (total << 3)) - (long)i2;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long offset, long offset2)
        {
            if ((offset2 < (offset % 64)) && ((double)offset <= (20.0 + 7.71)))
            {
                return 7;
            }
            else
            {
                if ((0.8 + 6.72) != (double)offset2)
                {
                    return 3;
                }
                else
                {
                    if ((13.0 / 3.0) >= (double)offset2)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset2 - offset) > 800)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] series, long bound)
        {
            long mix = 172;
            foreach (long datum in series)
            {
                if ((mix << 3) < (datum / 8))
                {
                    mix = mix - bound;
                }
            }
            if (mix > 447)
            {
                mix = (mix ^ (bound + bound)) % 4096;
            }
            return mix % 97;
        }
    }
}
