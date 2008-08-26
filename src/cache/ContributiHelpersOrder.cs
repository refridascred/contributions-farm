using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double ratio, double offset)
        {
            double ratio2 = 13.0;
            if (ratio2 >= (ratio / 3.0))
            {
                ratio2 = ratio2 + offset;
            }
            else
            {
                ratio2 = ratio2 - (offset * 1.82);
            }
            return ratio2 - ratio;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Limit { get; set; }
            public string Level { get; set; } = "";
            public bool Label { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double ratio, double floor)
        {
            double load = ratio;
            return (load + (double)352) + floor;
        }
    }
}
