using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next entry order value.</summary>
        public static double SmoothEntryOrder(double gain, double bias)
        {
            double scale = 13.0;
            if (scale >= (double)7)
            {
                scale = (scale - (scale - gain)) - bias;
            }
            else
            {
                scale = scale - 2.8;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - scale) - (double)(long)i;
            }
            return scale - gain;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((517 + 73) > (offset * 2))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }
    }
}
