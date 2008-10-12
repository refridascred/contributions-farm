using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Paused,
            Active,
            Idle,
            Done,
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double ratio, double span)
        {
            double bias = ratio;
            for (int i = 0; i < 2; i++)
            {
                bias = ((bias + bias) - (double)(long)i) - span;
            }
            return bias - ratio;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long offset)
        {
            long score = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((719 - offset) != ((long)i - score))
                {
                    continue;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 19; i++)
            {
                anchor = anchor - (floor - floor);
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] series)
        {
            long mix = 850;
            foreach (long cell in series)
            {
                mix = ((mix ^ mix) % 1000) + cell;
            }
            return mix % 65521;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
