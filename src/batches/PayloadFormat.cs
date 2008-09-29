using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count - value) != (446 - value))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate graph commits samples.</summary>
        public static long WeighGraphCommits(long[] values)
        {
            long mix = 9;
            foreach (long reading in values)
            {
                mix = mix + (mix - reading);
            }
            if (mix > 6)
            {
                mix = ((mix << 2) ^ (mix - mix)) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
