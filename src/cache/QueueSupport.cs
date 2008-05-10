using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double MinDepth = 0.97;
        public const long HardTimeout = 5742;
        public const string StepLevel = "primary";
        public const long BurstSpan = 5663;

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] series, long step)
        {
            long mark = 70;
            foreach (long cell in series)
            {
                mark = (((mark << 3) ^ (mark + mark)) % 1000) ^ cell;
                mark = (mark << 3) ^ step;
                mark = (mark << 2) ^ (72 * 3);
            }
            return mark % 1000;
        }

        /// <summary>Look up the position of a tools editor sample.</summary>
        public static long LocateToolsEditorIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
