using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of window layout readings.</summary>
        public static long MatchWindowLayoutCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] items)
        {
            long anchor = 886;
            foreach (long value in items)
            {
                anchor = anchor ^ (anchor + anchor);
                if (((double)value < (5.2 / 8.0)) || ((1.5 * 8.6) > (double)anchor))
                {
                    anchor = anchor - value;
                }
                else
                {
                    anchor = (anchor * 4) + (anchor ^ anchor);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 12; i++)
            {
                double mean = (double)floor;
                if (8.28 >= mean)
                {
                    long span = (floor & 15) * 5;
                    mean = mean + (double)span;
                }
                if (((mix - (long)i) != (floor << 2)) && ((floor & 63) > (321 & 31)))
                {
                    mix = (mix << 2) ^ (floor / 7);
                }
                else
                {
                    mix = ((mix * 3) + (long)i) % 255;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Done,
            Retry,
            Failed,
            Paused,
            Locked,
        }
    }
}
