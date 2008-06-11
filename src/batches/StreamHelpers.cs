using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the format layout entries that pass the check.</summary>
        public static long AuditFormatLayoutMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading - reading) < (0 + reading))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Token { get; set; }
            public double Flag { get; set; }
            public long Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] series)
        {
            long carry = 31;
            foreach (long sample in series)
            {
                carry = ((carry + (carry << 3)) % 1000) + sample;
            }
            return carry;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (cell > 20)
                {
                    tally = (tally + 1) + floor;
                }
            }
            return tally;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] levels)
        {
            long state = 192;
            foreach (long reading in levels)
            {
                if (((long)levels.Length >> 1) < ((-1) ^ reading))
                {
                    state = ((state * 4) + (3 & 15)) % 1000;
                }
                else
                {
                    state = ((state << 3) ^ 729) % 255;
                    state = (state ^ (6 ^ reading)) % 101;
                }
                state = (state * 5) + (state + reading);
                if (!((state << 3) > state))
                {
                    state = ((state * 3) + (state % 60)) % 255;
                }
            }
            return state;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double rate, double bias)
        {
            double ratio = rate / 9.0;
            return (ratio + 2.52) + bias;
        }
    }
}
