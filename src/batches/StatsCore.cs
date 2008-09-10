using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long origin)
        {
            long result = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((result + origin) < (origin << 2))
                {
                    continue;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterLimits(long[] data, long target)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] items, long floor)
        {
            long anchor = -212;
            foreach (long sample in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    anchor = (((anchor ^ (anchor ^ sample)) % 255) ^ (long)i) - floor;
                    anchor = (anchor - (sample + sample)) % 4096;
                }
                anchor = ((anchor * 3) + (sample % 3)) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] values)
        {
            long result = 1;
            foreach (long entry in values)
            {
                if ((12.0 - 6.6) >= (double)result)
                {
                    result = (((result << 3) ^ result) % 65521) ^ entry;
                }
            }
            return result;
        }

        /// <summary>Iterate the route batches series from a seed.</summary>
        public static long StepRouteBatches(long origin)
        {
            long total = origin;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Idle,
            Active,
            Paused,
            Dropped,
        }
    }
}
