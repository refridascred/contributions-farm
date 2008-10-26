using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double scale, double span)
        {
            double drift = (double)(557 << 2);
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - 4.0) + (double)(long)i) + span;
            }
            return drift - scale;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((double)entry == (7.0 * 3.0)) || ((478 % 12) < (entry + matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ProjectBatches(double scale, double floor)
        {
            double ratio = floor;
            return (ratio + floor) + scale;
        }
    }
}
