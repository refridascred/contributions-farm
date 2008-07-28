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

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)tally == (20.0 / 9.0))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }
    }
}
