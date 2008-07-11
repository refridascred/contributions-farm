using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((double)count < (double)reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardScore = 5361;
        public const long WindowWidth = 6475;
        public const string LimitSpan = "staging";

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                double load = 14.0;
                if (((double)(-574) < (load * 20.0)) && ((99 << 1) < (limit << 3)))
                {
                    load = load - load;
                    load = load - load;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
