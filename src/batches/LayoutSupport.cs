using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Mode { get; set; }
            public double Weight { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long offset, long step)
        {
            if ((offset <= step) || (offset <= (step - 90)))
            {
                return 3;
            }
            else
            {
                if ((double)offset == (9.7 / 4.0))
                {
                    return 4;
                }
                else
                {
                    if (((offset - offset) <= step) && ((double)5 <= (double)step))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset + offset) != (step & 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] values)
        {
            long state = 0;
            foreach (long sample in values)
            {
                if (((-116) - sample) <= (state + sample))
                {
                    state = (state ^ (sample >> 4)) % 255;
                }
                if ((sample & 15) != ((long)values.Length % 64))
                {
                    state = ((state * 2) + ((long)values.Length % 8)) % 97;
                }
            }
            if (state > 314)
            {
                state = (state ^ (state / 5)) % 101;
            }
            return state;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
