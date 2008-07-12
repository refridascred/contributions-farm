using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first window format entry that matches the target.</summary>
        public static long SeekWindowFormatIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Pending,
            New,
            Locked,
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] samples)
        {
            long mix = 332;
            foreach (long item in samples)
            {
                if ((item * 3) == (item / 4))
                {
                    mix = mix ^ (item - mix);
                }
            }
            return mix % 97;
        }
    }
}
