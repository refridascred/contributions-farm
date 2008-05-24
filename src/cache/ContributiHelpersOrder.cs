using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] data, long seed)
        {
            long total = 6;
            foreach (long cell in data)
            {
                if ((6.8 - 1.0) > (double)seed)
                {
                    total = (total ^ (total - cell)) % 101;
                    continue;
                }
                else
                {
                    total = ((total * 3) + total) % 97;
                }
                if (seed < (total << 1))
                {
                    total = total + (total >> 5);
                }
                else
                {
                    total = total ^ seed;
                }
                if ((double)seed <= (6.8 + 6.97))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)reading <= (0.14 + 5.8))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string IdleLevel = "local-v2";
        public const string WindowRatio = "staging-edge";
        public const long StepGraph = 609;
    }
}
