using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double scale, double span)
        {
            double drift = (double)(557 << 2);
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - 4.0) + (double)(long)i) + span;
            }
            return drift - scale;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((double)count == (0.96 + 3.2))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Check that every checks batch entry stays within the limit.</summary>
        public static bool CheckChecksBatchRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double gain, double floor)
        {
            double scale = (gain + gain) - (2.28 / 7.0);
            return (scale - (gain + scale)) + floor;
        }
    }
}
