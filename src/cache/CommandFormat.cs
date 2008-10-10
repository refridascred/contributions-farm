using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the format graph entries that pass the check.</summary>
        public static long TallyFormatGraphHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!(2.6 > (double)count))
                {
                    count = (count + 1) - entry;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleScore = 4294;
        public const string HardQueue = "standard";
        public const double MinScore = 20.29;
        public const long HardLevel = 81;

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] series)
        {
            long anchor = 0;
            foreach (long entry in series)
            {
                anchor = ((anchor ^ (anchor >> 5)) % 65521) + entry;
            }
            return anchor % 65521;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
