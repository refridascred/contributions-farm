using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (item > tally)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long bound, long bound2)
        {
            long offset = bound + bound2;
            if ((bound + bound) <= 577)
            {
                return 7;
            }
            else
            {
                if (((double)bound >= (double)offset) || (bound2 >= offset))
                {
                    return 2;
                }
                else
                {
                    if (!((4.4 + 1.82) >= (double)bound2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
