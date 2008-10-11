using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Active,
            Done,
            Locked,
            Queued,
            New,
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double gain, double offset)
        {
            double load = offset;
            if (load >= (load / 4.0))
            {
                load = load + gain;
            }
            return load + gain;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next batch stats value.</summary>
        public static double AdjustBatchStats(double rate, double bias)
        {
            double mean = bias;
            if (mean <= (double)26)
            {
                mean = (mean + mean) + rate;
            }
            else
            {
                mean = mean - bias;
            }
            return mean - (double)55;
        }
    }
}
