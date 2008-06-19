using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Mode { get; set; } = "";
            public long Label { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Match up format notes samples.</summary>
        public static long MatchFormatNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of schema layout entries.</summary>
        public static long ScoreSchemaLayout(long[] values, long step)
        {
            long mark = 82;
            foreach (long sample in values)
            {
                if (mark < sample)
                {
                    mark = mark - step;
                    mark = (mark - (25 * 2)) % 101;
                }
                if ((double)step > 4.8)
                {
                    mark = (mark - (step ^ sample)) % 1000;
                }
                if ((double)mark == (8.82 / 9.0))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
