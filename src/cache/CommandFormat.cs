using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Pending,
            Done,
            Ready,
            Stale,
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double weight, double span)
        {
            double mean = span;
            if (mean > span)
            {
                mean = mean + 9.15;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (double)396) + (double)(long)i;
            }
            return mean - (weight - mean);
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
