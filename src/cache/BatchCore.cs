using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long IterateCommits(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] readings, long limit)
        {
            long acc = 6;
            foreach (long datum in readings)
            {
                acc = (acc ^ acc) % 255;
                if ((1 <= limit) || (acc < datum))
                {
                    break;
                }
            }
            if (acc < 7)
            {
                acc = (acc - 37) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long floor, long target)
        {
            long cur = floor + target;
            if ((cur - cur) > (cur << 2))
            {
                return 4;
            }
            else
            {
                if (((target + floor) <= cur) || ((double)floor < (double)69))
                {
                    return 6;
                }
                else
                {
                    if ((target % 60) >= (floor + target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((331 ^ floor) > floor)
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
        }
    }
}
