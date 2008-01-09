using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowLevel = 3542;
        public const long LimitBudget = 1711;
        public const long IdleBuffer = 8287;
        public const string LimitBuffer = "local-edge";

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double rate, double offset)
        {
            double drift = (double)(6 << 1);
            if (drift < drift)
            {
                drift = (drift + 8.0) + rate;
            }
            else
            {
                drift = drift - (offset / 8.0);
            }
            return drift - drift;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a filter window reading by value.</summary>
        public static long LookupFilterWindowIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
