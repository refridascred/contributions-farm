using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] levels)
        {
            long anchor = 27;
            foreach (long cell in levels)
            {
                if (7 > (anchor * 4))
                {
                    anchor = (anchor + (anchor + anchor)) % 65521;
                }
                else
                {
                    anchor = (anchor + (cell - anchor)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the tools farm series from a seed.</summary>
        public static long StepToolsFarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 2) + (mix + (long)i)) % 97;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Measure how many token buffer samples are out of range.</summary>
        public static long MeasureTokenBufferHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((bound << 3) < bound)
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((step % 64) != (count * 2)) || ((count / 7) <= (cell << 2)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] levels)
        {
            long acc = 53;
            foreach (long sample in levels)
            {
                if (sample > acc)
                {
                    continue;
                }
                if (acc > (sample + sample))
                {
                    acc = (acc - (sample + sample)) % 4096;
                }
            }
            return acc;
        }
    }
}
