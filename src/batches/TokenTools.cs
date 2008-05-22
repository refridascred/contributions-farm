using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 17; i++)
            {
                mark = mark + (mark & 255);
                mark = (mark + mark) % 4096;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((8.0 < (double)floor) || ((cell * 5) > (cell >> 4)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long offset, long seed)
        {
            if ((offset / 3) < (6 % 64))
            {
                return 1;
            }
            else
            {
                if ((offset - offset) != (offset * 5))
                {
                    return 3;
                }
                else
                {
                    if ((seed % 3) <= (seed / 5))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset >= (seed / 2)) || ((offset % 3) < seed))
                        {
                            return 0;
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
