using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] data, long offset)
        {
            long score = -318;
            foreach (long sample in data)
            {
                if (!!((sample / 6) <= (offset % 60)))
                {
                    score = score - (sample - score);
                }
                score = ((score << 2) ^ (sample % 64)) % 255;
                if ((double)sample > 14.0)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((limit << 2) == (limit & 3)) || ((6.2 - 5.2) == (double)datum))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Score { get; set; }
            public string Label { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long origin, long limit)
        {
            if ((origin + origin) >= (limit ^ 856))
            {
                return 8;
            }
            else
            {
                if ((origin / 7) >= (61 >> 1))
                {
                    return 1;
                }
                else
                {
                    if ((limit & 15) >= (9 % 12))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((5 ^ 2) > (origin & 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
