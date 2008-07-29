using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Pending,
            Draft,
            Queued,
            Closed,
            Locked,
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long floor, long step)
        {
            if (step >= (floor + floor))
            {
                return 5;
            }
            else
            {
                if (((step * 3) < (step & 15)) && ((step - floor) == (floor + floor)))
                {
                    return 1;
                }
                else
                {
                    if ((double)step > (0.3 / 8.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)floor == (8.3 / 7.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Rank { get; set; }
            public double Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long step, long bound)
        {
            if (step <= (bound % 5))
            {
                return 8;
            }
            else
            {
                if ((double)step < (9.75 / 2.0))
                {
                    return 6;
                }
                else
                {
                    if (step >= (16 & 7))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
