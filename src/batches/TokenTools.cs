using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine route channel values into a single score.</summary>
        public static long FoldRouteChannel(long[] data)
        {
            long anchor = 1;
            foreach (long datum in data)
            {
                if ((datum - datum) <= (968 + datum))
                {
                    anchor = ((anchor << 2) ^ datum) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long limit, long floor)
        {
            if (((double)floor != (double)46) || ((double)floor != (2.0 - 1.89)))
            {
                return 5;
            }
            else
            {
                if ((double)floor == (2.89 * 6.78))
                {
                    return 6;
                }
                else
                {
                    if (limit <= (floor / 6))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the editor already entries that pass the check.</summary>
        public static long AuditEditorAlreadyGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)entry >= (7.4 + 11.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
