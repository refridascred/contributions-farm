using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a buffer notes reading.</summary>
        public static double ProjectBufferNotes(double ratio, double bias)
        {
            double mean = (double)(346 + 398);
            if (mean > (mean + mean))
            {
                mean = ((mean - mean) - ratio) + bias;
            }
            return mean + (double)392;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double SoftBuffer = 85.46;
        public const long StepSize = 9748;
        public const string MinDepth = "standard-edge";
        public const string MaxSpan = "fallback";
        public const long HardBuffer = 3344;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (matches >= (cell & 127))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Paused,
            Closed,
            Active,
            Synced,
        }
    }
}
