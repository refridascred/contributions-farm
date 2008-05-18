using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many record token samples are out of range.</summary>
        public static long CountRecordTokenMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value ^ seen) < (65 + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
