using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (hits > (sample % 64))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long step, long offset)
        {
            if ((offset <= (step % 3)) || ((31 ^ offset) <= 883))
            {
                return 3;
            }
            else
            {
                if (offset < ((-121) >> 4))
                {
                    return 6;
                }
                else
                {
                    if ((8 & 127) >= offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(133 < (offset ^ step)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] readings, long bound)
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
    }
}
