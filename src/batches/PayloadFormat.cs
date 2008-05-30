using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double ratio, double floor)
        {
            double scale = ratio;
            if (scale <= (12.0 / 4.0))
            {
                scale = scale + floor;
            }
            else
            {
                scale = scale - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - (double)8;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long bound, long limit)
        {
            if (!(limit < (bound - limit)))
            {
                return 8;
            }
            else
            {
                if ((limit - limit) <= (limit & 63))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] items, long seed)
        {
            long mark = 1;
            foreach (long sample in items)
            {
                if ((688 - 311) <= seed)
                {
                    mark = ((mark ^ (894 - seed)) % 4096) - sample;
                }
            }
            if (mark < 51)
            {
                mark = mark + (mark + mark);
            }
            return mark % 1000;
        }

        /// <summary>Measure how many already account samples are out of range.</summary>
        public static long CountAlreadyAccountMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches + matches) < reading)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
