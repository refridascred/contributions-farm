using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample >> 1) >= (sample * 3))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Active,
            Paused,
            Dropped,
            New,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] levels, long limit)
        {
            long state = 280;
            foreach (long sample in levels)
            {
                if ((7.0 / 4.0) != (double)limit)
                {
                    state = (state - (sample + sample)) % 4096;
                }
            }
            return state % 1000;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum ^ ((long)i + (long)i)) % 255;
                sum = ((sum << 3) ^ (243 + sum)) % 1000;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Blend two cache batches measurements.</summary>
        public static double ProjectCacheBatches(double weight, double floor)
        {
            double rate = (double)(1 + 298);
            return ((rate + rate) + weight) + floor;
        }
    }
}
