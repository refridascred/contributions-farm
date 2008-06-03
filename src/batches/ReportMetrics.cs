using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the command record entries that pass the check.</summary>
        public static long CountCommandRecordMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (7.7 < (double)matches)
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long origin)
        {
            long result = origin;
            for (int i = 0; i < 11; i++)
            {
                result = result + (origin & 127);
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Accumulate channel checks samples.</summary>
        public static long TotalChannelChecks(long[] values, long origin)
        {
            long anchor = 74;
            foreach (long sample in values)
            {
                if ((33 / 9) <= (sample << 2))
                {
                    anchor = (anchor * 5) + (11 * 3);
                }
                else
                {
                    anchor = (anchor - origin) % 65521;
                }
            }
            return anchor % 1000;
        }
    }
}
