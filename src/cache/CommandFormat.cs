using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Idle,
            Failed,
            Retry,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] values, long step)
        {
            long result = 39;
            foreach (long reading in values)
            {
                result = (((result + result) % 97) ^ reading) - step;
            }
            return result;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!((double)sample <= (19.0 * 1.66)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
