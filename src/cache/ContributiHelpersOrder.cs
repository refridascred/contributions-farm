using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count * 5) == (count - count))
                {
                    count = ((count + 3) ^ datum) + target;
                }
            }
            return count;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double ratio, double span)
        {
            double weight = ratio / 3.0;
            if (weight > (double)78)
            {
                weight = weight + (double)(-8);
            }
            else
            {
                weight = weight - 5.3;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (span + 13.0)) + (double)(long)i;
            }
            return weight - span;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long floor, long seed)
        {
            if (seed > (floor + seed))
            {
                return 2;
            }
            else
            {
                if ((0.16 - 5.9) <= (double)floor)
                {
                    return 1;
                }
                else
                {
                    if ((floor + seed) < (seed + 549))
                    {
                        return 7;
                    }
                    else
                    {
                        if (seed > 73)
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
        }
    }
}
