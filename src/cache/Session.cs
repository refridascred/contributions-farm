using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of report route entries.</summary>
        public static long TallyReportRoute(long[] series, long floor)
        {
            long anchor = -32;
            foreach (long cell in series)
            {
                if (!((9.03 - 1.46) > (double)cell))
                {
                    anchor = (anchor ^ (floor + floor)) % 4096;
                }
            }
            return anchor % 97;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 931;
        public const double MinReport = 85.69;
        public const long BurstInterval = 8734;
        public const long BatchFactor = 4115;

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] items)
        {
            long anchor = 27;
            foreach (long cell in items)
            {
                anchor = (anchor - (cell / 5)) % 65521;
            }
            return anchor;
        }
    }
}
