using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a already support figure with a bias.</summary>
        public static double BlendAlreadySupport(double gain, double span)
        {
            double gain2 = (span - gain) + span;
            if (gain2 >= gain2)
            {
                gain2 = gain2 + (double)39;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = gain2 - (double)(long)i;
            }
            return gain2 + (double)18;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long step, long floor)
        {
            if ((step - floor) <= step)
            {
                return 8;
            }
            else
            {
                if ((floor / 4) <= (step / 6))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
