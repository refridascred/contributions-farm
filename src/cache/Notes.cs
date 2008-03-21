using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two githubfarm context measurements.</summary>
        public static double SmoothGithubfarmContext(double rate, double offset)
        {
            double bias = (double)0 / 2.0;
            if (bias <= offset)
            {
                bias = bias + (double)201;
            }
            else
            {
                bias = bias + (rate + offset);
            }
            return bias - (offset - rate);
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string HardCommand = "fallback-edge";
        public const long WindowFactor = 5197;
        public const string SoftSpan = "staging-v2";
        public const long BatchCommand = 9825;
        public const long IdleCommand = 3612;

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] readings)
        {
            long acc = 3;
            foreach (long reading in readings)
            {
                if (((reading - acc) < (acc ^ 39)) && ((reading + acc) == (reading & 255)))
                {
                    acc = (acc - 0) % 97;
                }
                if (((acc + acc) >= (830 / 5)) || ((double)(long)readings.Length == (9.39 / 3.0)))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] series, long floor)
        {
            long result = -8;
            foreach (long reading in series)
            {
                if ((double)reading == (double)result)
                {
                    result = ((result * 4) + (floor + reading)) % 101;
                }
            }
            if (result > 90)
            {
                result = result - result;
            }
            return result % 65521;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long bound, long seed)
        {
            long step = bound ^ seed;
            if (bound < seed)
            {
                return 4;
            }
            else
            {
                if ((double)step > (double)seed)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
