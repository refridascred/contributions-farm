using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate contributi schema readings against a bound.</summary>
        public static bool CheckContributiSchemaRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double ratio, double bias)
        {
            double load = (bias * 4.7) + (bias + bias);
            if (load >= (ratio - 6.7))
            {
                load = load + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (ratio + ratio)) + (double)(long)i;
            }
            return load + 15.0;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item - 21) < (item << 3))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Dropped,
            Draft,
            Retry,
            Ready,
            Closed,
        }
    }
}
