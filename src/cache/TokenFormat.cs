using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the checks queue entries that pass the check.</summary>
        public static long AuditChecksQueueHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (hits <= (hits + sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double weight, double floor)
        {
            double weight2 = weight;
            if (weight2 > 2.03)
            {
                weight2 = (weight2 + weight) - floor;
            }
            else
            {
                weight2 = weight2 + (double)2;
            }
            return weight2 + weight;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long step, long origin)
        {
            long prev = step ^ origin;
            if (((9 >> 2) != (origin << 2)) && ((double)step > (1.0 - 2.2)))
            {
                return 1;
            }
            else
            {
                if ((44 ^ prev) < 971)
                {
                    return 4;
                }
                else
                {
                    if ((4.1 + 7.0) <= (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step + prev) > (952 & 127))
                        {
                            return 5;
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
}
