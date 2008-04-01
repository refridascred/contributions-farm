using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a order schema pair into a bucket.</summary>
        public static long SortOrderSchema(long offset, long step)
        {
            if (!(step <= (offset << 2)))
            {
                return 6;
            }
            else
            {
                if (1 < (step + step))
                {
                    return 4;
                }
                else
                {
                    if ((offset - 8) > (step + step))
                    {
                        return 0;
                    }
                    else
                    {
                        if (offset > (offset % 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
