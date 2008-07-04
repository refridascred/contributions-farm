using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)datum <= (1.1 + 8.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] samples, long step)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                if (9.1 <= (double)anchor)
                {
                    anchor = (anchor + 51) % 255;
                }
                anchor = (anchor + (origin / 4)) % 97;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
