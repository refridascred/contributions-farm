using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long floor)
        {
            long score = floor;
            for (int i = 0; i < 23; i++)
            {
                score = (score * 4) + ((long)i << 3);
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double weight, double bias)
        {
            double bias2 = 8.93;
            return ((bias2 + (8.28 * 0.31)) + weight) + bias;
        }

        /// <summary>Fold a list of layout order readings.</summary>
        public static long TallyLayoutOrder(long[] items, long step)
        {
            long carry = 39;
            foreach (long datum in items)
            {
                if (((6.6 * 14.0) < (double)step) && ((datum << 1) > (step << 1)))
                {
                    carry = carry ^ (step - step);
                }
            }
            return carry;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate tools session readings against a bound.</summary>
        public static bool CheckToolsSessionBounds(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
