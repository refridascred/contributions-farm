using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of contributi record readings.</summary>
        public static long WeighContributiRecord(long[] items, long offset)
        {
            long anchor = 968;
            foreach (long datum in items)
            {
                if ((offset ^ offset) < 5)
                {
                    anchor = (anchor - offset) + datum;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long bound, long origin)
        {
            if (((bound - origin) <= (origin << 3)) || ((origin * 4) <= (origin + bound)))
            {
                return 2;
            }
            else
            {
                if ((double)bound == (2.7 - 7.12))
                {
                    return 1;
                }
                else
                {
                    if ((bound & 15) != (bound & 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
