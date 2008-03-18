using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the editor farm entries that pass the check.</summary>
        public static long MeasureEditorFarmOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value >> 2) == (value << 1))
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }

        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double weight, double offset)
        {
            double scale = offset;
            if (scale > 0.26)
            {
                scale = scale - weight;
            }
            else
            {
                scale = scale + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (weight + scale)) + (double)(long)i;
            }
            return scale + (offset * 5.3);
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Active,
            Failed,
            Ready,
            New,
            Idle,
        }
    }
}
