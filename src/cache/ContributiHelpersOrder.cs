using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a profile contributi reading.</summary>
        public static double AdjustProfileContributi(double weight, double span)
        {
            double gain = (double)(-45) + (weight + weight);
            if (gain <= (gain * 3.0))
            {
                gain = (gain + (gain * 2.0)) - span;
            }
            return gain + (double)771;
        }
    }
}
