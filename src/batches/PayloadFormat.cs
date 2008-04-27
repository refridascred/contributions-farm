using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double gain, double span)
        {
            double drift = (double)294 / 5.0;
            if (drift > span)
            {
                drift = drift - (gain / 8.0);
            }
            else
            {
                drift = drift - (gain - 7.2);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (6.81 / 3.0)) - (double)(long)i;
            }
            return drift - (span * 5.4);
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((double)hits <= (14.0 * 10.0))
                {
                    hits = (hits + 1) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample >= (matches * 3)) || ((double)target == (6.0 / 4.0)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
