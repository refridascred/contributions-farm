using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Failed,
            Done,
            Retry,
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long seed, long origin)
        {
            if (4.2 <= (double)origin)
            {
                return 2;
            }
            else
            {
                if ((seed - 348) < origin)
                {
                    return 7;
                }
                else
                {
                    if ((origin - seed) > (seed ^ origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Size { get; set; } = "";
            public double Weight { get; set; }
            public string Label { get; set; } = "";
            public bool Ratio { get; set; }
        }
    }
}
