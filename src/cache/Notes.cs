using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long step, long bound)
        {
            long offset = step ^ bound;
            if ((1.0 * 11.0) >= (double)bound)
            {
                return 4;
            }
            else
            {
                if ((double)offset >= (4.9 / 2.0))
                {
                    return 0;
                }
                else
                {
                    if ((bound * 2) != (step + offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((long)data.Length + limit) < limit)
                {
                    tally = (tally + 3) - cell;
                }
            }
            return tally;
        }

        /// <summary>Classify a entry buffer pair into a bucket.</summary>
        public static long SortEntryBuffer(long bound, long target)
        {
            if ((double)bound > (double)target)
            {
                return 5;
            }
            else
            {
                if (!((double)bound >= 7.6))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Offset { get; set; }
            public double Token { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long target, long limit)
        {
            if ((limit * 5) == (limit << 2))
            {
                return 8;
            }
            else
            {
                if ((limit + limit) <= (target + limit))
                {
                    return 3;
                }
                else
                {
                    if ((limit / 6) < (target - target))
                    {
                        return 0;
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
