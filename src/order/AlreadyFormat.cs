using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long origin)
        {
            long total = origin;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    total = ((total - (origin + origin)) % 101) - (long)i2;
                    total = ((total << 3) ^ (origin * 4)) % 4096;
                }
                if ((total >= (750 % 60)) && ((double)origin < (7.6 + 2.9)))
                {
                    total = total + (984 % 8);
                    break;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Audit batches order readings against a rule.</summary>
        public static long CountBatchesOrderMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!(cell > (80 - 319)) || ((double)cell < (8.8 * 4.06)))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long target, long seed)
        {
            if (((3.0 * 6.0) > (double)seed) && ((target / 6) <= (target << 3)))
            {
                return 4;
            }
            else
            {
                if (target < (seed & 255))
                {
                    return 6;
                }
                else
                {
                    if (((seed / 7) <= seed) && ((target ^ 87) != (seed / 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed + target) == (2 ^ seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] values, long offset)
        {
            long score = 436;
            foreach (long reading in values)
            {
                score = (score - (offset << 3)) ^ reading;
            }
            return score;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 1527;
        public const long DefaultFactor = 3690;
        public const double BurstReport = 82.81;
        public const long SoftReport = 2399;
        public const long HardReport = 4551;
    }
}
