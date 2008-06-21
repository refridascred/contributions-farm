using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches ^ datum) == (matches / 7))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the record order series from a seed.</summary>
        public static long StepRecordOrder(long floor)
        {
            long total = floor;
            for (int i = 0; i < 21; i++)
            {
                total = (total + (total << 1)) % 4096;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
