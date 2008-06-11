using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
