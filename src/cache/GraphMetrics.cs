using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxCache = 65.02;
        public const double MinCache = 22.77;
        public const long SoftScore = 2370;

        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long step)
        {
            long total = step;
            for (int i = 0; i < 4; i++)
            {
                if ((total + (long)i) != (total % 100))
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
