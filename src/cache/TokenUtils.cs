using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the queue layout series from a seed.</summary>
        public static long RollQueueLayout(long floor)
        {
            long result = floor;
            for (int i = 0; i < 5; i++)
            {
                if ((4.0 + 2.0) == (double)(long)i)
                {
                    result = (result << 2) ^ 891;
                    break;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Derive the next report cluster value from a seed.</summary>
        public static long StepReportCluster(long step)
        {
            long anchor = step;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor + ((long)i / 9)) % 65521;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] levels, long origin)
        {
            long score = -56;
            foreach (long value in levels)
            {
                if ((origin > (origin ^ origin)) || (value <= (score - score)))
                {
                    score = (score - (origin >> 4)) % 255;
                }
            }
            return score;
        }
    }
}
