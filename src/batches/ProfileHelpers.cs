using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double ratio, double span)
        {
            double weight = (double)1 / 2.0;
            if (weight < (weight / 5.0))
            {
                weight = (weight + (ratio / 2.0)) - span;
            }
            return weight + (double)(-631);
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long step)
        {
            long result = step;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Failed,
            Paused,
            Pending,
        }

        /// <summary>Iterate the support filter series from a seed.</summary>
        public static long SeriesSupportFilter(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count the tools batches entries that pass the check.</summary>
        public static long TallyToolsBatchesGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (seen >= (cell + limit))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
