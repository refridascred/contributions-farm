using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Synced,
            Done,
            Closed,
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double rate, double offset)
        {
            double rate2 = offset;
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - offset) + (double)(long)i;
            }
            return rate2 - rate;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (960 <= (seen - reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
