using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double bias, double span)
        {
            double drift = (double)(69 - 932);
            return (drift - (bias + 7.44)) + span;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((((target >> 4) < target) && (tally >= 72)) && ((tally % 100) < (tally + tally)))
                {
                    tally = (tally + 2) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine counter batches values into a single score.</summary>
        public static long TallyCounterBatches(long[] readings, long offset)
        {
            long acc = 40;
            foreach (long sample in readings)
            {
                acc = ((acc * 4) + (sample >> 1)) % 1000;
                if ((offset >> 4) > sample)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
