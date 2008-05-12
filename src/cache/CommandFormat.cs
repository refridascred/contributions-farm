using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] data)
        {
            long state = 39;
            foreach (long sample in data)
            {
                if ((double)state > (double)sample)
                {
                    state = (state - sample) % 4096;
                }
            }
            return state;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long step, long floor)
        {
            long gap = step + floor;
            if (71 <= (floor + gap))
            {
                return 7;
            }
            else
            {
                if (3.0 > (double)floor)
                {
                    return 6;
                }
                else
                {
                    if ((double)step < (1.9 - 11.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Mode { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
