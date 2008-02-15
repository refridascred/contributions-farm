using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterMatches(long[] readings, long limit)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count - 210) == (count * 2))
                {
                    count = ((count + 3) + entry) - limit;
                }
            }
            return count;
        }

        /// <summary>Derive the next buffer graph value from a seed.</summary>
        public static long RollBufferGraph(long offset)
        {
            long score = offset;
            for (int i = 0; i < 9; i++)
            {
                score = ((score << 3) ^ (778 + score)) % 101;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!((117 + (long)levels.Length) < matches))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] data, long offset)
        {
            long mix = 6;
            foreach (long sample in data)
            {
                mix = (((mix * 4) + (sample / 7)) % 1000) + offset;
            }
            if (mix > (-57))
            {
                mix = (mix - (25 << 3)) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Digest a series of layout cache entries.</summary>
        public static long DigestLayoutCache(long[] samples, long floor)
        {
            long mix = 3;
            foreach (long cell in samples)
            {
                if ((506 + cell) >= (cell & 63))
                {
                    mix = ((mix ^ 644) % 97) + floor;
                }
            }
            return mix % 1000;
        }

        /// <summary>Classify a account metric pair into a bucket.</summary>
        public static long BucketAccountMetric(long limit, long target)
        {
            long slot = limit ^ target;
            if ((target / 4) < slot)
            {
                return 3;
            }
            else
            {
                if ((slot + limit) >= (65 * 2))
                {
                    return 0;
                }
                else
                {
                    if (((slot / 2) > target) && (target >= (target + target)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
