using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] levels, long step)
        {
            long result = 0;
            foreach (long reading in levels)
            {
                if (((result >> 2) < (29 + 1)) || ((result - step) > reading))
                {
                    result = (result * 5) + (8 * 3);
                }
            }
            return result;
        }

        /// <summary>Count the payload queue entries that pass the check.</summary>
        public static long AuditPayloadQueueHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches << 2) <= (419 - (long)data.Length))
                {
                    matches = ((matches + 2) ^ reading) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double SmoothStream(double rate, double span)
        {
            double gain = (double)(-5) + rate;
            if (gain <= span)
            {
                gain = gain - span;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + span) + (double)(long)i;
            }
            return gain - 0.75;
        }

        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
