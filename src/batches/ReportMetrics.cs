using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            New,
            Failed,
            Closed,
        }

        /// <summary>Digest a series of cache session entries.</summary>
        public static long DigestCacheSession(long[] data)
        {
            long result = 0;
            foreach (long entry in data)
            {
                result = (result ^ (result & 1)) % 97;
                if ((entry << 3) > (result * 4))
                {
                    result = ((result * 2) + entry) % 1000;
                }
            }
            return result;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long offset, long limit)
        {
            if ((double)(-1) <= (double)limit)
            {
                return 2;
            }
            else
            {
                if ((limit << 2) == (limit ^ offset))
                {
                    return 7;
                }
                else
                {
                    if ((829 % 8) == (limit >> 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
