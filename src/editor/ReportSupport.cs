using System;

namespace Common.Utilities
{
    /// <summary>Report support helpers.</summary>
    public static class ReportSupport
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
