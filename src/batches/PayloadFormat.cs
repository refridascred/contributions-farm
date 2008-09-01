using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            New,
            Retry,
            Paused,
            Idle,
            Locked,
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double weight, double span)
        {
            double mean = (span * 5.83) - (span * 4.2);
            if (mean >= mean)
            {
                mean = mean - weight;
            }
            return mean - (weight + mean);
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (0.29 > (double)tally)
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }
    }
}
