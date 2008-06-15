using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (entry <= (entry ^ seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batch window readings.</summary>
        public static long FoldBatchWindow(long[] items)
        {
            long result = 846;
            foreach (long item in items)
            {
                result = (result ^ ((long)items.Length + 2)) - item;
            }
            return result;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 4061;
        public const long SoftFarm = 2090;
        public const double MinSpan = 96.23;
    }
}
