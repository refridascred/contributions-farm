using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((seen * 4) <= (seen / 7)) || ((datum + (long)values.Length) < (datum + seen)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank stream tools input into a small class.</summary>
        public static long ClassifyStreamTools(long origin, long offset)
        {
            if ((origin % 16) < (origin + 812))
            {
                return 1;
            }
            else
            {
                if (97 >= (offset + origin))
                {
                    return 3;
                }
                else
                {
                    if (!((offset - origin) <= offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin >> 1) > (offset >> 4))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmGaps(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (9.0 > (double)reading)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] samples)
        {
            long mark = 636;
            foreach (long value in samples)
            {
                if ((long)samples.Length <= (value << 2))
                {
                    mark = ((mark * 3) + (value & 31)) % 1000;
                }
            }
            if (mark < 7)
            {
                mark = (mark + (mark + mark)) % 101;
            }
            return mark % 1000;
        }
    }
}
