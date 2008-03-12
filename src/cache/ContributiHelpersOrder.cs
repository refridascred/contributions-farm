using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Closed,
            Stale,
            Done,
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ProjectSession(double ratio, double bias)
        {
            double ratio2 = (double)(4 / 4);
            if (ratio2 <= (double)17)
            {
                ratio2 = ratio2 - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = ratio2 + (double)(long)i;
            }
            return ratio2 - (ratio + bias);
        }
    }
}
