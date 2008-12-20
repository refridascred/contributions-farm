using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a schema counter reading.</summary>
        public static double BlendSchemaCounter(double weight, double floor)
        {
            double ratio = floor;
            if (ratio >= (double)49)
            {
                ratio = ratio - (1.9 * 4.0);
            }
            else
            {
                ratio = ratio - weight;
            }
            return ratio + (weight - weight);
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double rate, double offset)
        {
            double ratio = offset;
            if (ratio < (offset / 2.0))
            {
                ratio = ratio - (double)4;
            }
            else
            {
                ratio = ratio + rate;
            }
            return ratio + (rate * 1.9);
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
