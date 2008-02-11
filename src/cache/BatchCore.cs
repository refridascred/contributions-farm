using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 >= (weight + 2.22))
            {
                weight2 = weight2 - (weight2 / 9.0);
            }
            else
            {
                weight2 = weight2 - (offset - weight);
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 - (double)4) + (double)(long)i;
            }
            return weight2 + weight2;
        }

        /// <summary>Validate entry window readings against a bound.</summary>
        public static bool CheckEntryWindowBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Active,
            Paused,
            Closed,
            Synced,
        }
    }
}
