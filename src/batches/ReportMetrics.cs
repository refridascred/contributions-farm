using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] readings)
        {
            long mix = 15;
            foreach (long value in readings)
            {
                mix = (mix + 957) ^ value;
            }
            if (mix > (-329))
            {
                mix = mix + (mix & 255);
            }
            return mix % 1000;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double ratio, double offset)
        {
            double drift = ratio;
            if (drift > (double)610)
            {
                drift = drift + (4.0 + ratio);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - ratio) + (double)(long)i;
            }
            return drift + offset;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen & 255) < (sample & 63))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
