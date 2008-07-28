using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double ratio, double offset)
        {
            double scale = 0.03;
            if (scale > offset)
            {
                scale = scale + (scale / 3.0);
            }
            return scale + (7.0 + ratio);
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Owner { get; set; }
            public bool Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long offset, long step)
        {
            long delta = offset + step;
            if ((4.72 > (double)step) && ((302 % 3) <= (delta % 64)))
            {
                return 3;
            }
            else
            {
                if (offset >= step)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
