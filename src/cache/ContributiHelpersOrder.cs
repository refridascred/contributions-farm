using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Locked,
            Retry,
            Idle,
            Draft,
            Pending,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] items)
        {
            long mix = 354;
            foreach (long item in items)
            {
                mix = ((mix << 2) ^ (-7)) % 255;
                if ((mix + item) > item)
                {
                    mix = (mix << 2) ^ (item + item);
                }
                if (171 >= (item << 1))
                {
                    mix = (mix * 5) + (mix % 97);
                }
                if ((item % 7) < item)
                {
                    break;
                }
            }
            if (mix > 50)
            {
                mix = ((mix << 3) ^ (mix ^ mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long origin, long offset)
        {
            long bound = origin ^ offset;
            if ((bound + 0) != (offset << 1))
            {
                return 7;
            }
            else
            {
                if ((double)origin <= (20.0 - 6.0))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
