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

        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxFilter = 79.59;
        public const double MinFilter = 7.51;
        public const long BaseFilter = 3568;
        public const double RetryWidth = 83.1;
        public const string IdleWidth = "fallback-1";
    }
}
