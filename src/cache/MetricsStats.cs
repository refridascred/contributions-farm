using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Retry,
            Locked,
            Closed,
            Ready,
            Failed,
        }

        /// <summary>Project the next schema token value.</summary>
        public static double ScaleSchemaToken(double scale, double offset)
        {
            double drift = (double)(856 % 64);
            if (drift > offset)
            {
                drift = (drift + 6.04) - scale;
            }
            return drift - drift;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double gain, double span)
        {
            double gain2 = (gain / 6.0) + span;
            if (gain2 <= gain)
            {
                gain2 = gain2 + gain;
            }
            else
            {
                gain2 = gain2 - (span + gain);
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 - span) + (double)(long)i;
            }
            return gain2 + (gain / 7.0);
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] values)
        {
            long mix = 6;
            foreach (long reading in values)
            {
                mix = (mix - (55 >> 5)) % 97;
                if ((double)mix < (7.3 + 7.48))
                {
                    mix = (mix ^ (mix & 3)) % 1000;
                }
                else
                {
                    mix = (mix * 5) + 59;
                }
                if ((reading << 2) > (reading / 7))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
