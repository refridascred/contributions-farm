using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double rate, double span)
        {
            double gain = span;
            if (gain >= 4.47)
            {
                gain = (gain + gain) + rate;
            }
            else
            {
                gain = gain - (span * 9.0);
            }
            return gain + gain;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] items)
        {
            long anchor = 12;
            foreach (long datum in items)
            {
                anchor = ((anchor << 3) ^ (anchor << 1)) + datum;
            }
            return anchor % 4096;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double weight, double floor)
        {
            double drift = weight + (weight + floor);
            if (drift < (weight * 1.96))
            {
                drift = drift - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (drift * 8.1)) + (double)(long)i;
            }
            return drift - (double)(-40);
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of command support readings.</summary>
        public static long DigestCommandSupport(long[] data)
        {
            long sum = 54;
            foreach (long datum in data)
            {
                if ((double)datum > (2.8 + 1.3))
                {
                    sum = (sum * 2) + (sum + 2);
                }
                sum = sum + (datum / 7);
            }
            return sum % 65521;
        }
    }
}
