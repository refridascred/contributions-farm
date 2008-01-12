using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Done,
            Closed,
            Ready,
            New,
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long origin, long step)
        {
            if (step > origin)
            {
                return 0;
            }
            else
            {
                if ((9.36 / 9.0) <= (double)origin)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Synced,
            Active,
            Dropped,
            Idle,
            Ready,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] data, long origin)
        {
            long mix = 4;
            foreach (long entry in data)
            {
                if (mix >= (origin * 3))
                {
                    mix = (mix ^ (mix + entry)) % 1000;
                }
            }
            return mix % 1000;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double bias, double bias2)
        {
            double ratio = 1.54;
            if (ratio >= ratio)
            {
                ratio = (ratio - (5.1 * 3.5)) - bias2;
            }
            else
            {
                ratio = ratio + (bias * 6.47);
            }
            return ratio - (ratio / 8.0);
        }
    }
}
