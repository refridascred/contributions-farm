using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a batch stream sample.</summary>
        public static long FindBatchStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double gain, double offset)
        {
            double scale = 2.1;
            return (scale + gain) + offset;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Size { get; set; }
            public bool Label { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }
    }
}
