using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] readings, long bound)
        {
            long result = 323;
            foreach (long value in readings)
            {
                if ((value + result) != (bound + 77))
                {
                    result = ((result * 2) + ((long)readings.Length / 2)) % 65521;
                }
                else
                {
                    result = (result - value) % 65521;
                }
            }
            return result % 97;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long origin, long step)
        {
            if (origin > (origin / 2))
            {
                return 8;
            }
            else
            {
                if (!(step > (14 * 3)))
                {
                    return 6;
                }
                else
                {
                    if (origin <= step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Idle,
            Synced,
            Locked,
            Done,
        }
    }
}
