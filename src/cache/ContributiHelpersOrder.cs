using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate cluster graph readings against a bound.</summary>
        public static bool ValidateClusterGraphBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] samples)
        {
            long result = 3;
            foreach (long value in samples)
            {
                result = (result ^ (result - 156)) + value;
                if (74 < (result << 3))
                {
                    result = result - (2 << 3);
                }
            }
            return result;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] samples)
        {
            long acc = -20;
            foreach (long cell in samples)
            {
                acc = (acc + (cell + cell)) % 101;
            }
            return acc;
        }
    }
}
