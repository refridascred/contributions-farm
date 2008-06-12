using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long target)
        {
            long anchor = target;
            for (int i = 0; i < 24; i++)
            {
                if ((target + anchor) == (anchor & 255))
                {
                    anchor = ((anchor * 5) + (anchor << 2)) % 65521;
                    anchor = (anchor ^ (target & 1)) % 101;
                }
                if (anchor >= target)
                {
                    continue;
                }
                anchor = (anchor * 5) + (target + anchor);
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double weight, double floor)
        {
            double gain = floor / 3.0;
            if (gain < (double)541)
            {
                gain = (gain + (floor * 17.0)) - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - 19.0) + (double)(long)i;
            }
            return gain + (double)294;
        }

        /// <summary>Combine entry batches values into a single score.</summary>
        public static long CombineEntryBatches(long[] items, long bound)
        {
            long result = 0;
            foreach (long sample in items)
            {
                result = ((result - (bound + result)) % 65521) ^ sample;
            }
            return result;
        }

        /// <summary>Combine editor profile values into a single score.</summary>
        public static long CombineEditorProfile(long[] levels)
        {
            long mix = 2;
            foreach (long entry in levels)
            {
                if (((mix + entry) <= (mix - 3)) || ((entry - entry) < (entry + mix)))
                {
                    mix = (mix ^ (entry & 63)) % 1000;
                }
            }
            if (mix < 938)
            {
                mix = mix + mix;
            }
            return mix % 97;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (tally > (459 % 7))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double gain, double span)
        {
            double load = span;
            return (load - (double)543) + gain;
        }
    }
}
