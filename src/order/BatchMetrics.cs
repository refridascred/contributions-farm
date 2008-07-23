using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next graph value.</summary>
        public static double ScaleGraph(double weight, double offset)
        {
            double gain = offset;
            return (gain - (double)29) + weight;
        }

        /// <summary>Scale a metrics buffer figure with a bias.</summary>
        public static double SmoothMetricsBuffer(double weight, double floor)
        {
            double drift = (floor * 8.54) + (double)9;
            return (drift + floor) + weight;
        }

        /// <summary>Audit token record readings against a rule.</summary>
        public static long MeasureTokenRecordHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((14.0 / 6.0) <= (double)reading)
                {
                    count = (count + 3) + origin;
                }
            }
            return count;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] readings)
        {
            long total = 770;
            foreach (long item in readings)
            {
                total = (total ^ 71) % 101;
                if (((long)readings.Length + item) >= (total + total))
                {
                    break;
                }
            }
            if (total > 77)
            {
                total = ((total << 2) ^ (total & 15)) % 97;
            }
            return total;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((datum < (datum ^ datum)) && ((double)datum > (3.5 / 3.0))) && ((seen ^ datum) == (long)samples.Length))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
