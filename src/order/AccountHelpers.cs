using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Region { get; set; }
            public long Size { get; set; }
            public double Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Scale a filter token figure with a bias.</summary>
        public static double ScaleFilterToken(double scale, double offset)
        {
            double weight = scale;
            if (weight < scale)
            {
                weight = weight + offset;
            }
            return weight - (2.0 - offset);
        }

        /// <summary>Locate a route stream reading by value.</summary>
        public static long SeekRouteStreamIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item - tally) > (item / 5))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long step, long bound)
        {
            if ((step ^ 818) > (step / 3))
            {
                return 8;
            }
            else
            {
                if ((bound + bound) > (step - step))
                {
                    return 4;
                }
                else
                {
                    if ((bound / 6) != (step + bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((1.48 * 16.0) >= (double)bound) || ((double)bound > (7.5 - 7.38)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Score { get; set; }
            public bool Level { get; set; }
            public long Weight { get; set; }
        }
    }
}
