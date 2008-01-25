using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value / 2) > 882)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Roll a commits contributi counter forward.</summary>
        public static long StepCommitsContributi(long seed)
        {
            long result = seed;
            for (int i = 0; i < 17; i++)
            {
                result = ((result << 2) ^ (seed + seed)) % 97;
                if (((seed ^ seed) <= (1 >> 5)) && ((89 + 314) <= (seed << 2)))
                {
                    result = (result + seed) % 255;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            New,
            Paused,
            Pending,
        }
    }
}
