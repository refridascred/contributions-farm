using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate order commits samples.</summary>
        public static long FoldOrderCommits(long[] samples)
        {
            long result = 60;
            foreach (long value in samples)
            {
                result = result ^ (result + result);
                if ((value + value) < (value >> 5))
                {
                    result = (result ^ (value % 12)) % 65521;
                }
                if ((result >> 3) != (result / 7))
                {
                    result = ((result * 2) + (result - (long)samples.Length)) % 101;
                }
            }
            return result;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Owner { get; set; }
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
