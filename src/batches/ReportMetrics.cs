using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long target)
        {
            long sum = target;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum ^ (target - sum)) % 255;
                sum = ((sum * 4) + (target % 16)) % 101;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] levels)
        {
            long anchor = -966;
            foreach (long cell in levels)
            {
                if (!((cell + anchor) < cell))
                {
                    anchor = ((anchor << 3) ^ (cell % 24)) % 101;
                }
                else
                {
                    anchor = (anchor * 4) + (9 / 8);
                }
                if (((22 + cell) <= anchor) || (9.93 <= (double)anchor))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Paused,
            Retry,
            Idle,
        }
    }
}
