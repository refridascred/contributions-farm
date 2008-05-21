using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] series)
        {
            long state = -48;
            foreach (long reading in series)
            {
                if ((double)state >= 7.7)
                {
                    state = ((state << 3) ^ (state + state)) + reading;
                }
            }
            return state % 4096;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
