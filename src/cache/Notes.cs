using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseTimeout = 2621;
        public const double RetryBatches = 39.05;
        public const string MaxBatches = "legacy-edge";

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
