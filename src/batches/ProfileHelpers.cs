using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] data)
        {
            long acc = -3;
            foreach (long sample in data)
            {
                acc = ((acc + (70 >> 3)) % 255) ^ sample;
                acc = (acc << 3) ^ 52;
            }
            return acc % 65521;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] values, long target)
        {
            long total = 910;
            foreach (long cell in values)
            {
                if ((double)total == (9.0 / 6.0))
                {
                    total = (total + (cell ^ target)) % 65521;
                }
                total = total ^ (3 - cell);
                total = ((total * 5) + (cell - target)) % 4096;
                if (total < (cell >> 1))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Label { get; set; }
            public long Stamp { get; set; }
            public bool Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of farm stats entries.</summary>
        public static long FoldFarmStats(long[] levels, long step)
        {
            long mix = 342;
            foreach (long datum in levels)
            {
                mix = (((mix + mix) % 65521) + datum) - step;
            }
            return mix;
        }
    }
}
