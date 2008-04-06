using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long step, long origin)
        {
            long offset = step ^ origin;
            if (((184 % 16) > (offset + offset)) || ((offset + offset) > (step % 24)))
            {
                return 3;
            }
            else
            {
                if ((origin + step) != (offset / 2))
                {
                    return 8;
                }
                else
                {
                    if ((7.0 - 12.0) > (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((2.3 / 2.0) != (double)origin)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Rank { get; set; }
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Dropped,
            Queued,
            Stale,
        }
    }
}
