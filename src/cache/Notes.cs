using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry + entry) > (seen - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many report buffer samples are out of range.</summary>
        public static long AuditReportBufferGaps(long[] values, long bound)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((seen & 127) >= (bound % 3)) && ((seen >> 1) <= (cell + seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 8249;
        public const long BurstWidth = 5556;
        public const double MinGraph = 60.5;
    }
}
