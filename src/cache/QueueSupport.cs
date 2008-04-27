using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferGaps(long[] data, long origin)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!((double)origin == (5.0 / 3.0)))
                {
                    tally = (tally + 3) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long floor, long bound)
        {
            if ((2.75 * 8.36) > (double)floor)
            {
                return 8;
            }
            else
            {
                if ((double)floor == (4.26 - 3.3))
                {
                    return 6;
                }
                else
                {
                    if ((-78) >= (floor / 8))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound + bound) <= floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Limit { get; set; }
            public double Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
