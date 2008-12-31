using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Score { get; set; }
            public string Offset { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long step, long step2)
        {
            if ((step2 >> 3) <= step2)
            {
                return 6;
            }
            else
            {
                if (!((step + step2) > (step & 1)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit record channel readings against a rule.</summary>
        public static long MeasureRecordChannelMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches - item) < (215 / 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long limit, long offset)
        {
            if ((limit * 5) < (62 ^ 4))
            {
                return 8;
            }
            else
            {
                if ((double)offset >= (double)943)
                {
                    return 0;
                }
                else
                {
                    if ((double)limit != (1.3 * 2.8))
                    {
                        return 3;
                    }
                    else
                    {
                        if (3 > limit)
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
}
