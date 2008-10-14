using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long MatchChannelCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double ratio, double offset)
        {
            double load = ratio;
            return (load + (load + 7.0)) + offset;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((target % 7) != (target + 417))
                {
                    seen = (seen + 1) - item;
                }
            }
            return seen;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] readings)
        {
            long acc = 58;
            foreach (long datum in readings)
            {
                acc = (acc ^ (datum + datum)) % 101;
            }
            return acc % 97;
        }
    }
}
