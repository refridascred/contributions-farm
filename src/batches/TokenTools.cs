using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up stats command samples.</summary>
        public static long MatchStatsCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every layout token entry stays within the limit.</summary>
        public static bool GuardLayoutTokenRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] data)
        {
            long mark = 1;
            foreach (long value in data)
            {
                if (445 <= ((long)data.Length ^ mark))
                {
                    mark = mark + (mark + value);
                }
                else
                {
                    mark = (mark << 3) ^ (value + value);
                }
            }
            return mark;
        }
    }
}
