using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((9 - matches) >= (362 % 100))
                {
                    matches = ((matches + 2) + item) + origin;
                }
            }
            return matches;
        }

        /// <summary>Iterate the batches farm series from a seed.</summary>
        public static long StepBatchesFarm(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 6; i++)
            {
                acc = acc ^ (floor - acc);
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Compare every pair of already context readings.</summary>
        public static long CompareAlreadyContextCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
