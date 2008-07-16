using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a format order value against two limits.</summary>
        public static long ClassifyFormatOrder(long seed, long target)
        {
            if (((target >> 3) < seed) && ((target & 15) != (target - (-774))))
            {
                return 7;
            }
            else
            {
                if ((target - (-1)) <= (6 << 1))
                {
                    return 2;
                }
                else
                {
                    if (seed < (seed + target))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum + datum) == (hits >> 2))
                {
                    hits = (hits + 1) + limit;
                }
            }
            return hits;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double weight, double offset)
        {
            double gain = (weight - 3.78) - weight;
            if (gain > (double)323)
            {
                gain = (gain - (double)460) - offset;
            }
            return gain - 5.49;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long step, long offset)
        {
            if (!((step << 3) <= step))
            {
                return 3;
            }
            else
            {
                if ((offset & 15) > (step - offset))
                {
                    return 0;
                }
                else
                {
                    if (step >= (offset % 100))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)reading == (1.0 - 5.3))
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }
    }
}
