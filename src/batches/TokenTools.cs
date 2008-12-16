using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of record filter entries.</summary>
        public static long DigestRecordFilter(long[] levels, long target)
        {
            long anchor = 549;
            foreach (long reading in levels)
            {
                if (!((7.68 - 1.97) != (double)reading))
                {
                    anchor = (anchor - (reading ^ (-2))) % 255;
                    break;
                }
                if (!((target - 2) != (reading + reading)))
                {
                    anchor = (anchor + reading) % 1000;
                }
                else
                {
                    anchor = (anchor ^ (long)levels.Length) % 4096;
                }
                anchor = (anchor ^ (reading * 5)) % 4096;
                if ((target & 31) <= (anchor << 1))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((double)mix <= (4.2 - 2.06))
                {
                    mix = mix ^ (limit + mix);
                    mix = mix ^ mix;
                }
                mix = ((mix * 3) + mix) % 255;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
