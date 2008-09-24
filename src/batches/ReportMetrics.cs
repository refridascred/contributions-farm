using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] series, long target)
        {
            long mix = 936;
            foreach (long cell in series)
            {
                if (cell <= (mix & 1))
                {
                    mix = (((mix << 3) ^ (cell / 2)) % 101) - target;
                }
                if ((18.0 * 5.9) == (double)cell)
                {
                    break;
                }
            }
            if (mix < 85)
            {
                mix = ((mix << 2) ^ mix) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Dropped,
            Closed,
            Locked,
            Ready,
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long step, long origin)
        {
            if ((double)step != (4.98 / 2.0))
            {
                return 6;
            }
            else
            {
                if (origin <= (origin / 2))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
