using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (value <= (seen >> 4))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Done,
            Locked,
            Active,
            Failed,
            Paused,
        }

        /// <summary>Grade a record queue value against two limits.</summary>
        public static long SortRecordQueue(long origin, long origin2)
        {
            if ((origin + origin) <= origin2)
            {
                return 6;
            }
            else
            {
                if (!((double)origin != (2.17 - 3.0)))
                {
                    return 5;
                }
                else
                {
                    if ((origin >> 2) == (origin * 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Offset { get; set; }
            public string Owner { get; set; } = "";
            public bool Ratio { get; set; }
        }
    }
}
