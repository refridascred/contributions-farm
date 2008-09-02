using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a payload window reading.</summary>
        public static double ScalePayloadWindow(double gain, double offset)
        {
            double scale = offset / 8.0;
            if (scale < (double)208)
            {
                scale = (scale + (double)7) + gain;
            }
            else
            {
                scale = scale + (scale * 3.0);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (double)13) + (double)(long)i;
            }
            return scale - (offset / 4.0);
        }

        /// <summary>Find the first format contributi entry that matches the target.</summary>
        public static long SeekFormatContributiIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Stamp { get; set; }
            public bool Mode { get; set; }
            public string Label { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
