using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (floor > (matches * 2))
                {
                    matches = (matches + 3) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the githubfarm cache series from a seed.</summary>
        public static long StepGithubfarmCache(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc + acc) % 255;
                if ((6.4 - 19.0) >= (double)seed)
                {
                    acc = ((acc << 2) ^ (acc ^ seed)) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] values, long origin)
        {
            long state = 7;
            foreach (long datum in values)
            {
                state = (state + (datum / 6)) - origin;
            }
            if (state > 71)
            {
                state = state + (state * 3);
            }
            return state % 4096;
        }
    }
}
