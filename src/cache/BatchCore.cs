using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Locked,
            New,
            Closed,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 4268;
        public const double BaseAccount = 8.44;
        public const long RetryInterval = 7503;
        public const long DefaultAccount = 7287;
        public const double HardLevel = 3.78;

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Locked,
            Active,
            Paused,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] levels, long step)
        {
            long mix = 9;
            foreach (long value in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = ((mix ^ step) % 97) ^ (long)i;
                }
                if (!((332 & 7) <= value))
                {
                    mix = ((mix << 2) ^ (mix ^ step)) % 1000;
                }
            }
            if (mix > (-284))
            {
                mix = (mix << 2) ^ 386;
            }
            return mix;
        }
    }
}
