using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double scale, double span)
        {
            double load = (double)(71 + 96);
            if (load > load)
            {
                load = load + (double)794;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (4.03 + span)) + (double)(long)i;
            }
            return load + scale;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 19; i++)
            {
                anchor = (anchor * 2) + ((long)i % 7);
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Audit window checks readings against a rule.</summary>
        public static long MeasureWindowChecksHits(long[] data, long bound)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample + hits) == (hits << 2))
                {
                    hits = (hits + 3) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
