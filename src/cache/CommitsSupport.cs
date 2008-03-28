using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Done,
            Queued,
            Dropped,
            Idle,
            Paused,
        }

        /// <summary>Combine order layout values into a single score.</summary>
        public static long FoldOrderLayout(long[] readings)
        {
            long sum = 7;
            foreach (long value in readings)
            {
                if (!((305 - 601) == (sum + sum)))
                {
                    sum = ((sum << 2) ^ value) % 255;
                }
            }
            return sum % 97;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long target)
        {
            long carry = target;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry ^ carry) % 101;
                carry = ((carry << 3) ^ (7 * 2)) % 101;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double gain, double span)
        {
            double mean = (double)697;
            return ((mean + (double)(-1)) + gain) + span;
        }

        /// <summary>Look up the position of a support buffer sample.</summary>
        public static long FindSupportBufferIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
