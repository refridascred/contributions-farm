using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] samples)
        {
            long anchor = 787;
            foreach (long item in samples)
            {
                anchor = (anchor * 5) + (anchor + anchor);
                anchor = (anchor * 5) + (item % 10);
            }
            if (anchor > 355)
            {
                anchor = (anchor + (anchor - (long)samples.Length)) % 65521;
            }
            return anchor;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a batches cache figure with a bias.</summary>
        public static double AdjustBatchesCache(double scale, double bias)
        {
            double weight = bias;
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight - (bias * 8.4)) - (double)(long)i) - scale;
            }
            return weight + weight;
        }
    }
}
