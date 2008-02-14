using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Failed,
            Queued,
            Draft,
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchBounds(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many checks token samples are out of range.</summary>
        public static long AuditChecksTokenOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (floor <= (floor >> 5))
                {
                    tally = (tally + 3) - cell;
                }
            }
            return tally;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long bound, long seed)
        {
            long edge = bound + seed;
            if ((edge + 85) == (bound + seed))
            {
                return 5;
            }
            else
            {
                if (((bound & 1) <= 5) && ((seed - bound) <= seed))
                {
                    return 7;
                }
                else
                {
                    if ((bound - edge) > bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed ^ seed) > (bound ^ bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of payload batch entries.</summary>
        public static long DigestPayloadBatch(long[] samples, long offset)
        {
            long mix = 80;
            foreach (long entry in samples)
            {
                if ((93 + entry) >= (entry << 1))
                {
                    mix = ((mix + (799 + entry)) % 101) - offset;
                }
            }
            if (mix < 711)
            {
                mix = (mix << 2) ^ ((long)samples.Length + (-35));
            }
            return mix;
        }
    }
}
