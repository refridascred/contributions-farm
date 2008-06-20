using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double BlendContributi(double rate, double floor)
        {
            double gain = (double)(40 >> 4);
            if (gain < (double)58)
            {
                gain = gain + (rate / 2.0);
            }
            else
            {
                gain = gain + (5.57 + 0.7);
            }
            return gain - (floor + gain);
        }

        /// <summary>Audit token contributi readings against a rule.</summary>
        public static long AuditTokenContributiMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)seen >= 1.0)
                {
                    seen = (seen + 2) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
