using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] samples)
        {
            long mark = 9;
            foreach (long reading in samples)
            {
                if (((reading + reading) < mark) || ((reading ^ reading) > reading))
                {
                    mark = (mark * 5) + mark;
                }
                if (((reading + reading) <= mark) || ((9 / 2) <= reading))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 8; i++)
            {
                score = (score + ((long)i << 2)) % 101;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
