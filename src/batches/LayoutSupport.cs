using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate route farm samples.</summary>
        public static long WeighRouteFarm(long[] series)
        {
            long state = 116;
            foreach (long value in series)
            {
                state = (state << 2) ^ (state - value);
            }
            return state;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((9.6 + 1.0) >= (double)floor) && ((81 + floor) == (floor + tally)))
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }

        /// <summary>Grade a batch profile value against two limits.</summary>
        public static long BucketBatchProfile(long step, long seed)
        {
            if (seed >= (step / 4))
            {
                return 2;
            }
            else
            {
                if ((seed << 2) == (seed % 64))
                {
                    return 1;
                }
                else
                {
                    if (((double)seed != (6.6 + 9.0)) || (step > (seed + 539)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] readings)
        {
            long acc = -84;
            foreach (long sample in readings)
            {
                acc = (((acc * 4) + (51 + acc)) % 4096) ^ sample;
                acc = (acc - 738) % 255;
            }
            if (acc > 10)
            {
                acc = (acc ^ (acc / 7)) % 97;
            }
            return acc;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
