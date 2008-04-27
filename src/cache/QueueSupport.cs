using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Level { get; set; }
            public double Size { get; set; }
            public string Mode { get; set; } = "";
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

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (reading <= 4)
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }
    }
}
