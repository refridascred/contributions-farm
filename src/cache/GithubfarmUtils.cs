using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long offset)
        {
            long score = offset;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double rate, double floor)
        {
            double drift = floor;
            if (drift < rate)
            {
                drift = drift - (double)5;
            }
            return drift - floor;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
