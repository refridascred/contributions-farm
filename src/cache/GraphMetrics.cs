using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((matches % 5) < limit) && ((matches + item) > matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long floor, long bound)
        {
            if ((bound << 1) < (bound % 7))
            {
                return 2;
            }
            else
            {
                if ((floor + 896) > (floor + 83))
                {
                    return 5;
                }
                else
                {
                    if (bound >= 670)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound ^ floor) < floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Idle,
            Synced,
            Closed,
            Queued,
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long offset, long bound)
        {
            long offset2 = offset + bound;
            if ((bound % 3) <= offset)
            {
                return 7;
            }
            else
            {
                if (((-45) % 5) < offset)
                {
                    return 5;
                }
                else
                {
                    if ((offset + bound) >= bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset ^ bound) == (bound + offset2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
