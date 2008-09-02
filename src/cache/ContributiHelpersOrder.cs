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

        /// <summary>Audit tools support readings against a rule.</summary>
        public static long MeasureToolsSupportGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally + datum) < (-107))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                if (!(((double)step < (5.0 + 6.4)) || ((double)step != (2.3 * 3.0))))
                {
                    result = (result - result) % 255;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
