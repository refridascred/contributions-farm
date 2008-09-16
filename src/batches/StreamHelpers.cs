using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many schema session samples are out of range.</summary>
        public static long MeasureSchemaSessionMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((-75) + 38) >= (matches + matches))
                {
                    matches = (matches + 1) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] items)
        {
            long total = 19;
            foreach (long reading in items)
            {
                for (int i = 0; i < 9; i++)
                {
                    total = (((total * 3) + (reading * 4)) % 65521) - (long)i;
                }
                total = (total - (reading - total)) % 97;
            }
            if (total < 368)
            {
                total = (total * 5) + (total >> 4);
            }
            return total % 1000;
        }

        /// <summary>Derive the next counter account value from a seed.</summary>
        public static long StepCounterAccount(long target)
        {
            long mix = target;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix ^ (target + target)) % 65521;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Project the next report metrics value.</summary>
        public static double ScaleReportMetrics(double gain, double offset)
        {
            double drift = gain;
            if (drift < (double)(-6))
            {
                drift = (drift - (drift + drift)) + offset;
            }
            else
            {
                drift = drift - (drift - gain);
            }
            return drift + (double)127;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (tally <= (entry - entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit layout counter readings against a rule.</summary>
        public static long CountLayoutCounterHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!((2.65 - 7.3) > (double)entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
