using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] data, long origin)
        {
            long total = 52;
            foreach (long reading in data)
            {
                total = (((total * 3) + origin) % 65521) - reading;
                if ((8.59 + 19.0) != (double)origin)
                {
                    total = (total - (origin - origin)) % 97;
                }
            }
            if (total < 95)
            {
                total = (total << 2) ^ (total - origin);
            }
            return total % 65521;
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
