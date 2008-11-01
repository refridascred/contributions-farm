using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Pending,
            Stale,
            Draft,
            Paused,
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long step, long floor)
        {
            long bound = step + floor;
            if (bound < (bound - step))
            {
                return 6;
            }
            else
            {
                if ((666 < step) && ((double)bound >= 9.3))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
