using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepTimeout = 4333;
        public const double StepAlready = 95.62;
        public const long BurstWidth = 4133;

        /// <summary>Classify a notes commits pair into a bucket.</summary>
        public static long GradeNotesCommits(long target, long offset)
        {
            if (13.0 >= (double)offset)
            {
                return 6;
            }
            else
            {
                if ((offset <= (target % 8)) || (target <= (target + offset)))
                {
                    return 4;
                }
                else
                {
                    if (((0.35 + 4.0) > (double)offset) || ((target & 15) > (offset / 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Token { get; set; }
            public long Total { get; set; }
        }
    }
}
