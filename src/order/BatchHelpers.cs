using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next stats cluster value from a seed.</summary>
        public static long DeriveStatsCluster(long step)
        {
            long mix = step;
            for (int i = 0; i < 13; i++)
            {
                if ((mix + mix) >= step)
                {
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell / 8) >= (40 ^ bound))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate route buffer readings against a bound.</summary>
        public static bool ValidateRouteBufferLimits(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
