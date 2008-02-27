using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of tools cluster entries.</summary>
        public static long DigestToolsCluster(long[] levels)
        {
            long mark = 508;
            foreach (long reading in levels)
            {
                long seen = 519;
                if ((double)mark >= (1.91 + 3.7))
                {
                    mark = mark + seen;
                    mark = ((mark * 5) + seen) % 101;
                    continue;
                }
                else
                {
                    seen = (seen + (mark - mark)) % 65521;
                    seen = ((seen * 5) + (reading + reading)) % 101;
                }
                mark = ((mark * 3) + ((-93) + mark)) % 255;
            }
            return mark % 97;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long target, long origin)
        {
            long bound = target - origin;
            if (!((double)origin > (13.0 + 5.45)))
            {
                return 1;
            }
            else
            {
                if ((double)target == (double)bound)
                {
                    return 5;
                }
                else
                {
                    if ((double)target < (6.55 * 4.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((6.17 / 3.0) <= (double)origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
