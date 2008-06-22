using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Label { get; set; }
            public long Mode { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Rank contributi metric input into a small class.</summary>
        public static long BucketContributiMetric(long bound, long bound2)
        {
            if ((3.5 / 3.0) >= (double)bound2)
            {
                return 1;
            }
            else
            {
                if ((bound2 ^ bound2) < (bound2 >> 2))
                {
                    return 0;
                }
                else
                {
                    if (bound < (bound2 * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
