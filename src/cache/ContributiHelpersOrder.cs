using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Dropped,
            Retry,
            Pending,
            Draft,
            Closed,
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long step, long bound)
        {
            if (!((1.7 + 6.57) >= (double)bound))
            {
                return 1;
            }
            else
            {
                if (!((bound << 1) > bound))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] data, long floor)
        {
            long acc = 7;
            foreach (long cell in data)
            {
                if (((long)data.Length - acc) < (cell + acc))
                {
                    acc = acc - (floor + floor);
                }
                else
                {
                    acc = (acc ^ (-115)) % 97;
                }
            }
            return acc;
        }
    }
}
