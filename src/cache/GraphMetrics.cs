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

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((double)hits != (2.7 / 5.0))
                {
                    hits = ((hits + 2) + entry) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
