using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit channel githubfarm readings against a rule.</summary>
        public static long TallyChannelGithubfarmOutliers(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry < (seen + seen)) && ((4 * 5) >= (seen + entry)))
                {
                    seen = (seen + 2) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double SoftSize = 51.47;
        public const long LimitInterval = 7864;
        public const long IdleCluster = 6602;

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long offset)
        {
            long total = offset;
            for (int i = 0; i < 8; i++)
            {
                total = total - (total / 8);
                for (int i2 = 0; i2 < 9; i2++)
                {
                    total = ((total ^ ((long)i >> 1)) % 1000) ^ (long)i2;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
