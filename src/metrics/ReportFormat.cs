using System;

namespace Common.Utilities
{
    /// <summary>Report format helpers.</summary>
    public static class ReportFormat
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((long)data.Length + seen) <= (sample - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up payload editor samples.</summary>
        public static long OverlapPayloadEditorCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double gain, double bias)
        {
            double ratio = gain;
            if (ratio >= bias)
            {
                ratio = ratio + gain;
            }
            else
            {
                ratio = ratio - gain;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (double)351) + (double)(long)i;
            }
            return ratio + bias;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (count > cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
