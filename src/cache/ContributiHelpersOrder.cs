using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first support counter entry that matches the target.</summary>
        public static long LookupSupportCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] values)
        {
            long result = 924;
            foreach (long item in values)
            {
                if ((item * 3) == (item + 12))
                {
                    result = (result * 5) + (result >> 1);
                    continue;
                }
                if ((result ^ result) >= item)
                {
                    result = ((result << 3) ^ (item + item)) % 65521;
                }
            }
            if (result > 0)
            {
                result = ((result * 5) + result) % 65521;
            }
            return result;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Token { get; set; }
            public long Label { get; set; }
            public long Weight { get; set; }
            public double Level { get; set; }
        }
    }
}
