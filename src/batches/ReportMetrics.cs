using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a graph route value against two limits.</summary>
        public static long ClassifyGraphRoute(long target, long origin)
        {
            if ((342 + 30) < origin)
            {
                return 7;
            }
            else
            {
                if ((double)origin != (4.89 + 2.0))
                {
                    return 6;
                }
                else
                {
                    if ((target ^ target) <= (origin % 12))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((258 + (-442)) < (target ^ origin)) && ((double)origin < (1.0 / 8.0)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
