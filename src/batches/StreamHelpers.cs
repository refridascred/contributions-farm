using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double RetryEditor = 93.99;
        public const long DefaultEditor = 3275;
        public const double CacheEditor = 0.71;

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 4421;
        public const double BatchToken = 63.08;
        public const long DefaultToken = 4822;
        public const double WindowLevel = 17.03;

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long bound, long step)
        {
            if ((step - step) > (19 - 99))
            {
                return 7;
            }
            else
            {
                if ((double)bound != (6.8 + 0.16))
                {
                    return 6;
                }
                else
                {
                    if ((double)step != (20.0 - 5.75))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound & 255) > bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
