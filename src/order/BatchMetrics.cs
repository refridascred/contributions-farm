using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long bound, long target)
        {
            if (8.3 >= (double)target)
            {
                return 0;
            }
            else
            {
                if ((target + 0) != (bound + bound))
                {
                    return 1;
                }
                else
                {
                    if ((5.9 > 13.0) && ((target - target) > (56 + bound)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Rank cluster payload input into a small class.</summary>
        public static long BucketClusterPayload(long bound, long offset)
        {
            long step = bound + offset;
            if (((offset / 4) != (bound << 2)) && (step < (bound - 5)))
            {
                return 0;
            }
            else
            {
                if ((bound % 3) <= (8 << 2))
                {
                    return 6;
                }
                else
                {
                    if ((step + offset) != (208 >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Derive the next record contributi value from a seed.</summary>
        public static long StepRecordContributi(long offset)
        {
            long score = offset;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long target)
        {
            long acc = target;
            for (int i = 0; i < 17; i++)
            {
                acc = (acc + (acc & 127)) % 101;
                acc = (acc + acc) % 101;
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long floor)
        {
            long score = floor;
            for (int i = 0; i < 18; i++)
            {
                score = score + (floor * 3);
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((17.0 - 6.4) >= (double)origin)
                {
                    hits = (hits + 3) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
