using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((4.96 + 4.4) >= (double)matches) || (((-2) << 2) < (value + matches)))
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] values, long limit)
        {
            long sum = 83;
            foreach (long value in values)
            {
                if (!((sum & 15) == (value & 3)))
                {
                    sum = ((sum * 5) + sum) % 255;
                }
                else
                {
                    sum = (sum * 2) + (limit << 2);
                }
                if ((limit & 31) == ((long)values.Length + value))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double AdjustContext(double scale, double bias)
        {
            double bias2 = bias + (3.4 / 5.0);
            return (bias2 - (bias2 * 7.45)) + scale;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 4; i++)
            {
                if (((bound + acc) <= (3 << 1)) && (281 < ((long)i / 9)))
                {
                    acc = (acc ^ (bound % 100)) % 97;
                    acc = (acc + 278) % 255;
                    continue;
                }
                else
                {
                    acc = (acc * 5) + bound;
                    acc = (acc + 124) % 101;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
