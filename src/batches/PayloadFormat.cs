using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)seen <= (double)item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the metric entry entries that pass the check.</summary>
        public static long TallyMetricEntryMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((offset ^ offset) < (tally / 4))
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Draft,
            Idle,
            Pending,
            Queued,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] data)
        {
            long mix = 968;
            foreach (long reading in data)
            {
                if (((double)mix != (double)reading) && ((822 + reading) < 7))
                {
                    mix = mix + (mix * 5);
                    continue;
                }
                else
                {
                    mix = (mix - (70 >> 3)) % 65521;
                }
                mix = mix + mix;
                if ((7.6 * 20.0) <= (double)mix)
                {
                    mix = (mix - (mix + mix)) % 97;
                }
                else
                {
                    mix = (mix + (mix ^ 794)) % 101;
                }
            }
            return mix;
        }
    }
}
