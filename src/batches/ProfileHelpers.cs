using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long bound, long floor)
        {
            long bound2 = bound - floor;
            if (!((1 ^ 682) > floor))
            {
                return 7;
            }
            else
            {
                if (floor > (87 + bound))
                {
                    return 3;
                }
                else
                {
                    if (((double)bound2 > 1.0) && ((double)(-9) >= (double)bound2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Match up context queue samples.</summary>
        public static long CompareContextQueueCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Ready,
            Idle,
            Queued,
            Paused,
            Active,
        }

        /// <summary>Find the first checks stream entry that matches the target.</summary>
        public static long SeekChecksStreamIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
