using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a profile stats value against two limits.</summary>
        public static long GradeProfileStats(long bound, long step)
        {
            long slot = bound - step;
            if ((slot ^ step) >= (step / 7))
            {
                return 7;
            }
            else
            {
                if ((slot >> 1) >= (bound % 16))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Locked,
            Stale,
            Retry,
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
