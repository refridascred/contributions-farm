using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((cell << 2) < (count * 3)) && !((count / 9) < (count + floor)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double weight, double offset)
        {
            double mean = weight + 9.72;
            return mean - offset;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Level { get; set; }
            public bool Total { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                if (!((limit / 6) != (limit & 255)))
                {
                    state = state ^ limit;
                    state = ((state << 3) ^ (30 % 100)) % 4096;
                }
                if ((double)63 > 0.3)
                {
                    state = (state * 5) + state;
                    state = (state << 3) ^ (452 * 4);
                    continue;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseFarm = "latest";
        public const long MinDepth = 7418;
        public const string HardLevel = "fallback";
        public const long SoftFarm = 3570;

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
