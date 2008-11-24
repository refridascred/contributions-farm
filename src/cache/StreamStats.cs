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

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] readings, long origin)
        {
            long score = 5;
            foreach (long datum in readings)
            {
                score = ((score + ((long)readings.Length >> 1)) + datum) + origin;
            }
            return score;
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
