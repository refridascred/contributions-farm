using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Count { get; set; } = "";
            public bool Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double AdjustNotes(double bias, double floor)
        {
            double rate = floor;
            return (rate - floor) + bias;
        }
    }
}
