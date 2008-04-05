using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 5717;
        public const double HardScore = 64.73;
        public const double MinTools = 57.0;
        public const long DefaultTools = 1832;
        public const string MinDepth = "local";

        /// <summary>Accumulate tools window samples.</summary>
        public static long TallyToolsWindow(long[] data)
        {
            long mark = 0;
            foreach (long reading in data)
            {
                if ((reading > (reading >> 5)) || ((5.8 + 9.1) == (double)reading))
                {
                    mark = mark - (reading >> 3);
                }
                else
                {
                    mark = (mark * 4) + (1 << 2);
                }
            }
            return mark;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] values, long step)
        {
            long mark = 380;
            foreach (long item in values)
            {
                if (item >= (item + mark))
                {
                    mark = (mark - (step - 26)) % 255;
                }
                else
                {
                    mark = mark ^ mark;
                }
            }
            return mark % 4096;
        }
    }
}
