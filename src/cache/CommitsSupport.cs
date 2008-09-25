using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double rate, double offset)
        {
            double weight = offset * 4.57;
            if (weight <= 13.0)
            {
                weight = (weight - offset) - rate;
            }
            else
            {
                weight = weight + 3.27;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight - (double)0;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Token { get; set; } = "";
            public long Weight { get; set; }
            public double Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] data)
        {
            long acc = 3;
            foreach (long reading in data)
            {
                acc = (acc + (acc - reading)) % 97;
            }
            return acc;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long seed, long offset)
        {
            if (((3 - offset) >= (seed - 410)) || (seed < (offset - seed)))
            {
                return 1;
            }
            else
            {
                if ((offset >> 1) <= (offset - offset))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double SmoothCluster(double rate, double span)
        {
            double drift = (rate + span) - span;
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (drift * 6.8)) + (double)(long)i;
            }
            return drift - span;
        }
    }
}
