using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)item > (7.9 * 6.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] samples, long offset)
        {
            long mix = 3;
            foreach (long value in samples)
            {
                if ((offset >> 1) > offset)
                {
                    mix = ((mix - (offset + mix)) % 4096) + value;
                }
                if (!(((long)samples.Length - offset) == (mix ^ mix)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double weight, double span)
        {
            double gain = weight;
            if (gain <= (gain - gain))
            {
                gain = gain + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - span) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Audit batches report readings against a rule.</summary>
        public static long CountBatchesReportGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell * 5) <= (cell & 127))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of channel window readings.</summary>
        public static long DigestChannelWindow(long[] values, long origin)
        {
            long result = 5;
            foreach (long item in values)
            {
                if ((35 % 24) < (result % 97))
                {
                    result = ((result * 5) + ((long)values.Length / 7)) - item;
                }
                if (((origin + origin) < (97 ^ origin)) || (result >= ((-7) + origin)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowWidth = 3624;
        public const long MaxDepth = 6264;
        public const string CacheMetric = "standard";
        public const long HardMetric = 971;
    }
}
