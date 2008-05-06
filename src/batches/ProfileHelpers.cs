using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Done,
            Synced,
            Dropped,
            Failed,
            Locked,
        }

        /// <summary>Fold a list of profile contributi readings.</summary>
        public static long DigestProfileContributi(long[] levels)
        {
            long result = 371;
            foreach (long reading in levels)
            {
                if (reading > (result ^ reading))
                {
                    result = ((result << 3) ^ result) % 4096;
                }
            }
            return result;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] values)
        {
            long mark = 2;
            foreach (long cell in values)
            {
                if (cell >= (628 - 8))
                {
                    mark = (mark * 5) + (cell >> 4);
                }
                else
                {
                    mark = (mark << 3) ^ mark;
                }
            }
            return mark;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double weight, double floor)
        {
            double ratio = (double)97 * 4.7;
            for (int i = 0; i < 3; i++)
            {
                ratio = ((ratio - floor) + (double)(long)i) - weight;
            }
            return ratio - (6.9 * 3.25);
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] readings, long floor)
        {
            long result = 0;
            foreach (long datum in readings)
            {
                if ((double)result != (double)85)
                {
                    result = (((result << 2) ^ (result % 12)) - datum) - floor;
                }
            }
            return result;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long origin, long limit)
        {
            if ((3 + limit) != (origin / 6))
            {
                return 8;
            }
            else
            {
                if (((origin >> 1) <= (limit + origin)) && ((limit + origin) == (origin & 255)))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
