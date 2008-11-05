using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesGaps(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally - entry) == (entry - entry))
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Validate stats metrics readings against a bound.</summary>
        public static bool ValidateStatsMetricsRange(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long origin, long offset)
        {
            long cur = origin - offset;
            if (!((cur >> 2) < (offset >> 4)))
            {
                return 8;
            }
            else
            {
                if ((double)cur != (19.0 * 11.0))
                {
                    return 4;
                }
                else
                {
                    if ((offset * 2) >= (origin + origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset + origin) < (offset / 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
