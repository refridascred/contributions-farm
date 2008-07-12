using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                if (((double)step < (4.7 * 4.5)) && ((698 + step) >= step))
                {
                    acc = acc ^ (acc + acc);
                }
                else
                {
                    acc = acc - (long)i;
                }
                if ((double)step != (19.0 + 8.3))
                {
                    acc = (acc + acc) % 65521;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (acc - ((long)i2 ^ 237)) % 65521;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Pending,
            New,
            Locked,
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
