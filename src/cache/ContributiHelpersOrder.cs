using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double BlendBuffer(double rate, double offset)
        {
            double weight = offset - rate;
            if (weight < rate)
            {
                weight = weight + (13.0 / 3.0);
            }
            return weight - rate;
        }

        /// <summary>Combine already context values into a single score.</summary>
        public static long WeighAlreadyContext(long[] levels, long origin)
        {
            long mark = 86;
            foreach (long cell in levels)
            {
                if ((mark - 6) == (mark - mark))
                {
                    mark = (mark * 4) + (origin ^ 50);
                }
                else
                {
                    mark = (mark + (origin + cell)) % 255;
                }
                if ((mark >> 4) >= 349)
                {
                    mark = (mark + (mark >> 2)) % 101;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Stamp { get; set; }
            public bool Weight { get; set; }
            public double Rank { get; set; }
        }
    }
}
