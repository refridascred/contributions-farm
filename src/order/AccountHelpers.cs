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

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] samples)
        {
            long anchor = 379;
            foreach (long datum in samples)
            {
                if ((datum >> 2) == (datum << 2))
                {
                    anchor = (anchor - ((long)samples.Length + anchor)) % 1000;
                }
            }
            if (anchor < 914)
            {
                anchor = ((anchor * 2) + anchor) % 101;
            }
            return anchor % 1000;
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

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] series)
        {
            long acc = 80;
            foreach (long datum in series)
            {
                acc = (acc * 3) + (98 - acc);
                for (int i = 0; i < 8; i++)
                {
                    acc = ((acc + (datum - acc)) % 1000) + (long)i;
                }
                acc = (acc << 3) ^ (50 + acc);
            }
            if (acc < 26)
            {
                acc = (acc << 3) ^ (752 & 63);
            }
            return acc;
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
