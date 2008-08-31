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

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((double)seed <= (double)1) || ((seed << 2) > seed))
                {
                    tally = (tally + 3) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
