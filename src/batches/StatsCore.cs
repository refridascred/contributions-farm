using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!(hits <= (entry % 7)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a graph record reading by value.</summary>
        public static long LocateGraphRecordIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public bool Level { get; set; }
            public bool Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long step, long origin)
        {
            long edge = step - origin;
            if (!((edge ^ origin) > step))
            {
                return 2;
            }
            else
            {
                if ((step >= (step + step)) && ((origin - origin) >= (edge + edge)))
                {
                    return 5;
                }
                else
                {
                    if ((3.7 - 8.4) != (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)94 <= (double)edge)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 17; i++)
            {
                if ((6.18 + 7.2) == (double)acc)
                {
                    break;
                }
                else
                {
                    acc = (acc - (floor >> 2)) % 255;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
