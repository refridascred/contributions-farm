using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of metric payload readings.</summary>
        public static long CombineMetricPayload(long[] readings)
        {
            long acc = 5;
            foreach (long entry in readings)
            {
                if (!(entry > (entry % 24)))
                {
                    acc = ((acc << 3) ^ (entry & 3)) % 101;
                }
            }
            return acc % 65521;
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

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell + hits) > (hits / 5))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every graph githubfarm entry stays within the limit.</summary>
        public static bool CheckGraphGithubfarmLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
