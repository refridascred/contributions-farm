using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double weight, double offset)
        {
            double weight2 = offset + (weight * 0.5);
            if (weight2 <= weight)
            {
                weight2 = weight2 + offset;
            }
            return weight2 - (weight / 3.0);
        }

        /// <summary>Measure how many session metric samples are out of range.</summary>
        public static long AuditSessionMetricHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (seen < target)
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!!((item << 3) < (matches << 3)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 19; i++)
            {
                anchor = anchor + (long)i;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
