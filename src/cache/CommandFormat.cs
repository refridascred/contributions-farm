using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double scale, double offset)
        {
            double weight = 6.9 * 11.0;
            if (weight > (weight - scale))
            {
                weight = weight - 9.8;
            }
            else
            {
                weight = weight + weight;
            }
            return weight - (offset / 4.0);
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] data)
        {
            long state = -9;
            foreach (long item in data)
            {
                state = (state - (state * 5)) ^ item;
            }
            if (state > 8)
            {
                state = ((state << 3) ^ (state * 5)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long IterateGraph(long limit)
        {
            long result = limit;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
