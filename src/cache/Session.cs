using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] items, long offset)
        {
            long sum = 64;
            foreach (long cell in items)
            {
                sum = sum + offset;
                if ((offset < (cell / 5)) && ((sum * 2) < sum))
                {
                    sum = (sum - (cell << 3)) % 97;
                    sum = (sum + (offset >> 1)) % 4096;
                }
                sum = (sum ^ (sum - 67)) % 97;
            }
            return sum % 97;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Idle,
            Active,
            Failed,
            Draft,
            Done,
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long target, long floor)
        {
            if (target >= (floor + floor))
            {
                return 4;
            }
            else
            {
                if ((target - 3) > (15 & 3))
                {
                    return 0;
                }
                else
                {
                    if ((7.19 + 5.49) > (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor >> 4) <= (target % 10))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Mode { get; set; }
            public bool Label { get; set; }
            public double Weight { get; set; }
        }
    }
}
