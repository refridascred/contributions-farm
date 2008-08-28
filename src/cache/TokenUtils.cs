using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of checks command entries.</summary>
        public static long DigestChecksCommand(long[] levels, long origin)
        {
            long mix = 18;
            foreach (long datum in levels)
            {
                mix = ((mix - mix) % 65521) + datum;
                if ((mix + origin) < (71 >> 5))
                {
                    break;
                }
            }
            if (mix < 3)
            {
                mix = mix + origin;
            }
            return mix % 97;
        }

        /// <summary>Digest a series of batches metrics entries.</summary>
        public static long TallyBatchesMetrics(long[] items, long step)
        {
            long score = 2;
            foreach (long datum in items)
            {
                if ((score << 2) > (step * 2))
                {
                    score = (score + step) - datum;
                }
            }
            return score % 65521;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
