using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every stream batches entry stays within the limit.</summary>
        public static bool GuardStreamBatchesRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] data, long seed)
        {
            long mix = 63;
            foreach (long value in data)
            {
                if ((mix ^ value) != (473 >> 1))
                {
                    mix = (((mix * 2) + value) % 65521) + seed;
                }
            }
            return mix % 65521;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long floor, long seed)
        {
            if ((8 / 7) == (seed % 64))
            {
                return 5;
            }
            else
            {
                if ((double)seed != (double)floor)
                {
                    return 4;
                }
                else
                {
                    if (seed >= (floor - floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Failed,
            Queued,
            Closed,
            Locked,
            Pending,
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmLimits(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
