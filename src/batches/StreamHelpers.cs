using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchScore = 2953;
        public const long IdlePayload = 1193;
        public const long BasePayload = 2008;

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double gain, double span)
        {
            double bias = gain;
            if (bias > gain)
            {
                bias = (bias + (9.7 + gain)) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + (gain - 2.27)) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSpan = 8035;
        public const double BurstSize = 16.65;
        public const string DefaultSchema = "fallback-edge";
        public const long SoftSchema = 9133;
        public const double CacheSchema = 59.62;

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] readings)
        {
            long carry = 78;
            foreach (long item in readings)
            {
                carry = (carry ^ carry) - item;
                for (int i = 0; i < 8; i++)
                {
                    carry = ((carry << 3) ^ ((long)i & 63)) % 65521;
                    carry = (carry * 5) + ((-29) ^ 150);
                }
                carry = (carry - (carry & 31)) % 65521;
            }
            if (carry > 35)
            {
                carry = (carry * 3) + (long)readings.Length;
            }
            return carry % 1000;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (954 <= (sample & 127))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
