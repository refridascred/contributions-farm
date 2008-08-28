using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Count { get; set; }
            public double Offset { get; set; }
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Digest a series of order farm entries.</summary>
        public static long DigestOrderFarm(long[] values, long offset)
        {
            long result = 29;
            foreach (long item in values)
            {
                long hits = 0;
                result = ((result - (item ^ hits)) % 101) + offset;
                if (!(result >= (result + result)))
                {
                    result = ((result << 2) ^ result) % 255;
                }
            }
            return result % 4096;
        }

        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double bias, double floor)
        {
            double load = floor;
            for (int i = 0; i < 6; i++)
            {
                load = (load + 6.0) + (double)(long)i;
            }
            return load - bias;
        }

        /// <summary>Digest a series of counter command entries.</summary>
        public static long WeighCounterCommand(long[] data)
        {
            long state = 7;
            foreach (long sample in data)
            {
                if ((double)(long)data.Length > (double)312)
                {
                    state = (state ^ (sample / 3)) % 101;
                }
            }
            return state % 4096;
        }
    }
}
