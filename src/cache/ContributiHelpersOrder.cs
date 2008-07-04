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

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Label { get; set; } = "";
            public double Mode { get; set; }
            public long Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Total { get; set; }
            public long Weight { get; set; }
        }
    }
}
