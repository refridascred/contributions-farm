using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a tools contributi pair into a bucket.</summary>
        public static long SortToolsContributi(long offset, long offset2)
        {
            if ((9.73 - 2.0) != (double)offset2)
            {
                return 1;
            }
            else
            {
                if ((double)offset == (7.7 + 2.46))
                {
                    return 5;
                }
                else
                {
                    if (offset <= (offset2 * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (10 <= offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Owner { get; set; }
            public bool Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double scale, double offset)
        {
            double gain = (offset - scale) / 7.0;
            if (gain < gain)
            {
                gain = gain - gain;
            }
            return gain - (double)40;
        }
    }
}
