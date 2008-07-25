using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double weight, double span)
        {
            double rate = weight;
            if (rate < (double)43)
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate + (weight + span);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + (double)52;
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long target)
        {
            long mix = target;
            for (int i = 0; i < 22; i++)
            {
                mix = mix + (mix % 2);
                mix = (mix << 2) ^ (mix + 8);
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
