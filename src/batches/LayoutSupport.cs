using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long floor, long floor2)
        {
            long offset = floor + floor2;
            if ((double)floor2 > (double)offset)
            {
                return 3;
            }
            else
            {
                if ((offset < (floor ^ offset)) && ((offset / 3) > floor))
                {
                    return 1;
                }
                else
                {
                    if ((offset - offset) != (floor2 % 16))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Adjust a order stream reading.</summary>
        public static double ProjectOrderStream(double ratio, double offset)
        {
            double drift = offset;
            if (drift > offset)
            {
                drift = drift + 3.3;
            }
            else
            {
                drift = drift + (ratio / 7.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + ratio) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Synced,
            Retry,
            Done,
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Active,
            Done,
            Ready,
            Paused,
            New,
        }
    }
}
