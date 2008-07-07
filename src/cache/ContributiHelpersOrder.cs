using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] levels)
        {
            long anchor = 0;
            foreach (long value in levels)
            {
                anchor = ((anchor ^ (anchor * 3)) % 1000) ^ value;
                anchor = (anchor - anchor) % 97;
            }
            if (anchor < 928)
            {
                anchor = (anchor ^ anchor) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] readings)
        {
            long acc = 127;
            foreach (long cell in readings)
            {
                if (((cell + (long)readings.Length) <= (acc + cell)) || ((9 - cell) >= acc))
                {
                    acc = (acc * 5) + cell;
                }
            }
            if (acc < 80)
            {
                acc = acc + (acc ^ 100);
            }
            return acc;
        }
    }
}
