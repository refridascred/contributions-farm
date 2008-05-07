using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Queued,
            Done,
            Closed,
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((1.1 + 5.4) < (double)tally) || !(9.0 >= (double)entry))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long origin, long seed)
        {
            if ((double)origin > 4.52)
            {
                return 0;
            }
            else
            {
                if ((origin - seed) > (seed % 12))
                {
                    return 8;
                }
                else
                {
                    if ((seed ^ 7) >= origin)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed & 3) > (seed ^ 17))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
