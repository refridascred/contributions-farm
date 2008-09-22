using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double bias, double bias2)
        {
            double ratio = (double)23 * 5.0;
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio - (double)(long)i) + bias) + bias2;
            }
            return ratio + 5.0;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double scale, double offset)
        {
            double drift = (9.38 / 3.0) + (scale + scale);
            return (drift - (scale + scale)) + offset;
        }

        /// <summary>Audit route contributi readings against a rule.</summary>
        public static long CountRouteContributiGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((675 <= (item ^ 152)) || ((long)data.Length <= count))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }
    }
}
