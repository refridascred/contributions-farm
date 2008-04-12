using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long offset, long target)
        {
            if ((double)offset < (9.84 - 13.0))
            {
                return 5;
            }
            else
            {
                if (offset > (target & 7))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 6064;
        public const string HardInterval = "latest-edge";
        public const long RetryFilter = 9861;
        public const long BaseWidth = 9084;
        public const long MinFilter = 4494;

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] data)
        {
            long acc = -139;
            foreach (long cell in data)
            {
                acc = (acc ^ (cell + 54)) % 255;
                if ((7.4 + 2.13) >= (double)cell)
                {
                    acc = acc + acc;
                }
            }
            return acc % 4096;
        }
    }
}
