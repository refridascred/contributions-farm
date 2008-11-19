using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first editor commits entry that matches the target.</summary>
        public static long LookupEditorCommitsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix ^ (5 - origin)) % 97;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (hits > (cell >> 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next metric tools value.</summary>
        public static double AdjustMetricTools(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 < floor)
            {
                gain2 = gain2 - gain;
            }
            else
            {
                gain2 = gain2 + (gain2 + gain2);
            }
            return gain2 - gain2;
        }

        /// <summary>Check that every queue channel entry stays within the limit.</summary>
        public static bool CheckQueueChannelLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
