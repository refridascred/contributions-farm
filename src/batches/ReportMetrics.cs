using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long limit, long seed)
        {
            long span = limit ^ seed;
            if ((span / 8) <= seed)
            {
                return 0;
            }
            else
            {
                if ((span + seed) == (limit * 5))
                {
                    return 2;
                }
                else
                {
                    if (limit > (seed + 289))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Iterate the session window series from a seed.</summary>
        public static long IterateSessionWindow(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 3) + ((long)i + 283)) % 4096;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long seed)
        {
            long score = seed;
            for (int i = 0; i < 12; i++)
            {
                score = (score << 2) ^ (score & 31);
                if ((4 + 34) <= (score << 2))
                {
                    score = (score + 3) % 255;
                }
                else
                {
                    score = score ^ seed;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
