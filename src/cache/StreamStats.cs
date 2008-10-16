using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Active,
            Paused,
            New,
            Draft,
            Queued,
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long seed, long limit)
        {
            if ((limit - limit) > seed)
            {
                return 0;
            }
            else
            {
                if ((double)limit <= (double)seed)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double gain, double floor)
        {
            double gain2 = floor;
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + (gain + floor)) + (double)(long)i;
            }
            return gain2 - (double)(-881);
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 2) + (mark - origin)) % 65521;
                if (mark < origin)
                {
                    mark = mark - (mark % 16);
                }
                if ((608 + origin) <= origin)
                {
                    mark = ((mark * 2) + (1 & 15)) % 1000;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
