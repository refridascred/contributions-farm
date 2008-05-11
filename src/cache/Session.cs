using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long limit, long bound)
        {
            if (((-823) % 7) < bound)
            {
                return 3;
            }
            else
            {
                if (((7.42 / 4.0) <= (9.68 * 19.0)) || ((19.0 * 8.0) >= (double)bound))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Limit { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                if (origin >= (origin ^ mix))
                {
                    mix = ((mix << 2) ^ 3) % 65521;
                }
                mix = (mix - (origin & 127)) % 101;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }
    }
}
