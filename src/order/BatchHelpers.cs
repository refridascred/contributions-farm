using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Stale,
            Idle,
            Closed,
            Failed,
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double scale, double floor)
        {
            double load = floor;
            if (load >= 2.04)
            {
                load = load + (scale + scale);
            }
            return load + (double)9;
        }
    }
}
