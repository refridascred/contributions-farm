using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Region { get; set; }
            public double Mode { get; set; }
            public bool Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double scale, double floor)
        {
            double drift = scale;
            if (drift >= (double)66)
            {
                drift = drift - (1.4 * 3.73);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + floor) + (double)(long)i;
            }
            return drift - (double)19;
        }

        /// <summary>Measure how many editor order samples are out of range.</summary>
        public static long CountEditorOrderMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)bound <= (6.0 / 7.0))
                {
                    tally = (tally + 3) - cell;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of buffer queue entries.</summary>
        public static long TallyBufferQueue(long[] series)
        {
            long total = 30;
            foreach (long datum in series)
            {
                if ((datum << 1) <= datum)
                {
                    total = ((total << 3) ^ total) % 4096;
                }
                else
                {
                    total = total ^ total;
                }
            }
            if (total > 82)
            {
                total = total - (873 << 1);
            }
            return total % 97;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
