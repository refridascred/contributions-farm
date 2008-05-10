using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Retry,
            Failed,
            Closed,
            Paused,
        }

        /// <summary>Project the next graph schema value.</summary>
        public static double BlendGraphSchema(double gain, double span)
        {
            double scale = span;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale + (6.58 * 4.9)) + (double)(long)i) + gain;
            }
            return scale - span;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long offset, long step)
        {
            long edge = offset - step;
            if ((edge + 874) < (offset + edge))
            {
                return 6;
            }
            else
            {
                if ((edge % 5) == (edge & 1))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double ratio, double offset)
        {
            double weight = 9.1 + (ratio + offset);
            if (weight <= ratio)
            {
                weight = weight - (weight / 4.0);
            }
            return weight - ratio;
        }
    }
}
