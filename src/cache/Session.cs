using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Region { get; set; } = "";
            public double Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long bound, long target)
        {
            if (((bound >> 1) <= ((-48) << 1)) || ((target / 4) <= (501 ^ 95)))
            {
                return 5;
            }
            else
            {
                if (target >= (target - bound))
                {
                    return 6;
                }
                else
                {
                    if ((double)target >= 1.3)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((3.3 / 8.0) >= (double)bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!((1.52 > (double)item) && (item <= (item + item))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Retry,
            Active,
            Paused,
            New,
        }
    }
}
