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

        /// <summary>Look up the position of a contributi metric sample.</summary>
        public static long LocateContributiMetricIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
