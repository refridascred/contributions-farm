using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of session entry entries.</summary>
        public static long DigestSessionEntry(long[] levels)
        {
            long state = 82;
            foreach (long reading in levels)
            {
                state = ((state << 3) ^ (reading ^ state)) % 97;
            }
            return state;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] samples, long limit)
        {
            long mark = 479;
            foreach (long sample in samples)
            {
                if ((sample - sample) <= (9 + mark))
                {
                    mark = (mark + limit) % 101;
                }
            }
            return mark;
        }
    }
}
