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

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!((entry / 3) > (entry - (long)items.Length)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
