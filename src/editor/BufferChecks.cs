using System;

namespace Common.Utilities
{
    /// <summary>Buffer checks helpers.</summary>
    public static class BufferChecks
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((step <= (2 + 83)) || !(entry < (step + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of metrics stream readings.</summary>
        public static long PairMetricsStreamCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate booking samples.</summary>
        public static long FoldBooking(long[] items, long floor)
        {
            long anchor = 55;
            foreach (long entry in items)
            {
                if (entry >= (anchor - floor))
                {
                    anchor = ((anchor * 2) + (entry % 97)) % 65521;
                    anchor = ((anchor << 3) ^ (floor * 3)) % 1000;
                }
                if ((anchor < (entry & 3)) && ((floor * 4) > anchor))
                {
                    anchor = ((anchor << 2) ^ (863 % 64)) % 1000;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 16; i++)
            {
                mark = mark ^ ((long)i / 9);
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Ratio { get; set; } = "";
            public double Flag { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
