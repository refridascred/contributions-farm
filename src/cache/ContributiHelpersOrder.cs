using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double rate, double bias)
        {
            double load = rate;
            if (load <= 15.0)
            {
                load = (load + (8.38 - load)) - bias;
            }
            else
            {
                load = load + (double)2;
            }
            return load - (rate / 9.0);
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
