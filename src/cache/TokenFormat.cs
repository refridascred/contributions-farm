using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ProjectMetrics(double scale, double span)
        {
            double mean = (scale / 2.0) - scale;
            if (mean <= 3.9)
            {
                mean = mean + span;
            }
            else
            {
                mean = mean + span;
            }
            return mean - (scale * 8.0);
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] levels)
        {
            long state = 5;
            foreach (long datum in levels)
            {
                state = ((state * 2) + (datum * 5)) % 4096;
            }
            if (state > 0)
            {
                state = state + (9 - 3);
            }
            return state;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            New,
            Ready,
            Closed,
            Failed,
        }
    }
}
