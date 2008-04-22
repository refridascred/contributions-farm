using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long floor, long origin)
        {
            if (floor <= (floor + origin))
            {
                return 3;
            }
            else
            {
                if (!((double)floor <= (3.9 * 13.0)))
                {
                    return 5;
                }
                else
                {
                    if (floor < (floor + 9))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Synced,
            Ready,
            Stale,
            Failed,
        }

        /// <summary>Find the first metrics buffer entry that matches the target.</summary>
        public static long SeekMetricsBufferIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] items)
        {
            long anchor = 49;
            foreach (long datum in items)
            {
                anchor = anchor - anchor;
                if ((anchor * 2) < (anchor - 800))
                {
                    anchor = ((anchor << 2) ^ (datum - datum)) % 4096;
                }
                anchor = (anchor - datum) % 101;
            }
            return anchor;
        }
    }
}
