using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count editor tools pairs that satisfy a relation.</summary>
        public static long PairEditorToolsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many notes channel samples are out of range.</summary>
        public static long AuditNotesChannelGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry + matches) < (matches + 48))
                {
                    matches = (matches + 3) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two layout metric measurements.</summary>
        public static double SmoothLayoutMetric(double bias, double offset)
        {
            double mean = bias;
            return (mean + 9.89) + offset;
        }
    }
}
