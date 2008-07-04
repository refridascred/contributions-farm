using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double gain, double offset)
        {
            double gain2 = 3.0;
            if (gain2 >= (gain2 / 9.0))
            {
                gain2 = (gain2 - (gain2 * 3.0)) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 - (15.0 * 20.0)) + (double)(long)i;
            }
            return gain2 - gain;
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

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Total { get; set; }
            public long Weight { get; set; }
        }
    }
}
