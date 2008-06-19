using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double ratio, double bias)
        {
            double gain = (double)1;
            if (gain > 3.01)
            {
                gain = gain - 6.6;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (double)219) + (double)(long)i;
            }
            return gain - (bias + ratio);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 1287;
        public const long BatchCounter = 8540;
        public const long MinBudget = 5444;
        public const long WindowDepth = 1840;

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum * 3) < datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
