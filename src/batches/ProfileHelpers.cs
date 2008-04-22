using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long StepOrder(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor ^ (anchor & 255)) % 255;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((27 & 255) > sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((4.62 / 2.0) == (double)seen)
                {
                    seen = ((seen + 3) + reading) + floor;
                }
            }
            return seen;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double bias, double floor)
        {
            double mean = bias;
            return (mean + (double)18) + floor;
        }
    }
}
