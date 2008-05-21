using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two support token measurements.</summary>
        public static double ScaleSupportToken(double bias, double floor)
        {
            double rate = (double)(33 & 1);
            if (rate >= (1.2 * 2.5))
            {
                rate = (rate + (double)6) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - rate) - (double)(long)i;
            }
            return rate + (bias - bias);
        }

        /// <summary>Adjust a already profile reading.</summary>
        public static double AdjustAlreadyProfile(double bias, double offset)
        {
            double weight = bias;
            if (weight <= (bias - offset))
            {
                weight = weight + (offset + bias);
            }
            else
            {
                weight = weight + (weight / 9.0);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + (weight - bias);
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first buffer context entry that matches the target.</summary>
        public static long LookupBufferContextIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
