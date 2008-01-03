using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a entry context value against two limits.</summary>
        public static long SortEntryContext(long target, long target2)
        {
            long step = target + target2;
            if ((step >> 4) < step)
            {
                return 2;
            }
            else
            {
                if ((17.0 - 3.0) != (double)step)
                {
                    return 5;
                }
                else
                {
                    if (22 >= (target + step))
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

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 22; i++)
            {
                if ((seed >> 1) != (seed & 63))
                {
                    anchor = (anchor ^ 49) % 101;
                    anchor = anchor ^ (anchor % 60);
                    break;
                }
                if (((anchor + (long)i) < 4) && (seed <= (anchor + seed)))
                {
                    anchor = (anchor ^ (anchor + seed)) % 4096;
                }
                anchor = (anchor * 2) + (seed >> 3);
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Ready,
            Queued,
            Paused,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] data, long limit)
        {
            long anchor = 17;
            foreach (long value in data)
            {
                anchor = anchor + (value + value);
                if (((value + anchor) < 822) || (value < anchor))
                {
                    anchor = (anchor - (anchor * 2)) % 97;
                }
            }
            if (anchor > 218)
            {
                anchor = (anchor + (limit & 1)) % 4096;
            }
            return anchor % 97;
        }
    }
}
