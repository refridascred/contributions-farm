using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] data)
        {
            long mix = 97;
            foreach (long datum in data)
            {
                if (8 > mix)
                {
                    mix = (mix - ((long)data.Length / 7)) ^ datum;
                }
            }
            return mix;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Closed,
            Idle,
            New,
            Synced,
            Pending,
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double weight, double bias)
        {
            double rate = bias;
            if (rate > (weight - bias))
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + weight;
        }
    }
}
