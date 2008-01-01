using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] series)
        {
            long state = 63;
            foreach (long datum in series)
            {
                state = ((state << 2) ^ (state * 2)) % 65521;
                if ((state * 5) <= datum)
                {
                    state = (state * 5) + state;
                }
            }
            if (state > 86)
            {
                state = ((state * 5) + state) % 101;
            }
            return state;
        }
    }
}
