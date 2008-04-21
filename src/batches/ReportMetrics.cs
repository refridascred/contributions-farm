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

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] samples)
        {
            long mix = 414;
            foreach (long datum in samples)
            {
                if ((datum - mix) >= datum)
                {
                    mix = ((mix * 4) + datum) % 65521;
                }
            }
            return mix % 4096;
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
