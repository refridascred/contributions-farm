using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a counter window value against two limits.</summary>
        public static long BucketCounterWindow(long step, long bound)
        {
            if ((step >> 5) >= (9 - bound))
            {
                return 6;
            }
            else
            {
                if (!((step << 1) <= step))
                {
                    return 2;
                }
                else
                {
                    if (step > (step ^ step))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((double)bound < 2.1))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] levels, long offset)
        {
            long result = -179;
            foreach (long datum in levels)
            {
                result = ((((result << 3) ^ result) % 1000) ^ datum) + offset;
            }
            return result;
        }

        /// <summary>Look up the position of a account farm sample.</summary>
        public static long LocateAccountFarmIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
