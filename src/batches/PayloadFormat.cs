using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long target)
        {
            long mix = target;
            for (int i = 0; i < 4; i++)
            {
                if ((7 % 24) >= mix)
                {
                    mix = (mix - (5 ^ 6)) % 1000;
                }
                if (target > (target * 4))
                {
                    long gap = mix + (mix + (long)i);
                    mix = (mix ^ (target - gap)) % 65521;
                }
                else
                {
                    mix = (mix + (mix ^ (long)i)) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstBudget = 4047;
        public const double LimitFormat = 25.25;
        public const long SoftScore = 3919;
        public const long BatchFormat = 1270;
        public const double BaseBudget = 61.69;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((floor >> 1) >= (floor - 81))
                {
                    hits = (hits + 1) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((double)value > (8.4 * 9.0))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
