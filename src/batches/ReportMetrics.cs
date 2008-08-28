using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!((double)bound >= (5.5 + 7.0)))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsMatches(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (datum > (datum + 633))
                {
                    matches = (matches + 3) + origin;
                }
            }
            return matches;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix - (mix >> 3)) % 97;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
