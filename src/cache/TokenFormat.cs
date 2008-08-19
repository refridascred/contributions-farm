using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Synced,
            Draft,
            Done,
            Paused,
        }

        /// <summary>Find the first account tools entry that matches the target.</summary>
        public static long LocateAccountToolsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long target, long floor)
        {
            if (!((target ^ target) < 20))
            {
                return 2;
            }
            else
            {
                if (!(5.3 <= (double)target))
                {
                    return 6;
                }
                else
                {
                    if (((floor & 127) > (floor + floor)) || ((double)floor >= (3.8 / 8.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target + (-2)) < (target % 100))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
