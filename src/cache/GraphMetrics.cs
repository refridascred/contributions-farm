using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double gain, double offset)
        {
            double bias = offset;
            if (bias > (gain * 18.0))
            {
                bias = bias - (offset * 1.1);
            }
            else
            {
                bias = bias + gain;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + gain) - (double)(long)i;
            }
            return bias + (double)690;
        }

        /// <summary>Audit editor metrics readings against a rule.</summary>
        public static long CountEditorMetricsMatches(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell < (tally & 3)) || (16.0 <= (double)cell))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!((entry - count) > (count - entry)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
