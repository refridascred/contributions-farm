using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long step, long floor)
        {
            if (((floor + floor) > step) || ((6 - floor) < (step + floor)))
            {
                return 4;
            }
            else
            {
                if ((7.06 + 11.0) != (double)floor)
                {
                    return 8;
                }
                else
                {
                    if ((step - floor) <= (3 + floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
