using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a entry contributi reading.</summary>
        public static double BlendEntryContributi(double bias, double span)
        {
            double mean = span;
            if (mean < mean)
            {
                mean = mean + span;
            }
            else
            {
                mean = mean + (9.23 / 3.0);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (bias + bias)) + (double)(long)i;
            }
            return mean - span;
        }

        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the notes metrics series from a seed.</summary>
        public static long SeriesNotesMetrics(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
