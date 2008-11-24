using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank cluster checks input into a small class.</summary>
        public static long BucketClusterChecks(long origin, long floor)
        {
            long edge = origin ^ floor;
            if ((edge * 5) <= (edge - origin))
            {
                return 8;
            }
            else
            {
                if (((8.0 / 7.0) == (double)edge) || ((double)origin <= (3.5 - 8.03)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long limit, long limit2)
        {
            if ((limit / 3) <= limit2)
            {
                return 2;
            }
            else
            {
                if ((4.6 / 8.0) > (double)limit2)
                {
                    return 8;
                }
                else
                {
                    if ((limit2 & 3) != (limit & 255))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long step)
        {
            long mark = step;
            for (int i = 0; i < 11; i++)
            {
                if (!((3 - 14) != (step + mark)))
                {
                    mark = ((mark << 3) ^ (mark & 15)) % 255;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] data)
        {
            long mix = 124;
            foreach (long reading in data)
            {
                if (9 >= (mix << 1))
                {
                    mix = ((mix * 2) + reading) % 1000;
                }
                if ((double)mix > (2.67 * 4.13))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
