using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank already checks input into a small class.</summary>
        public static long ClassifyAlreadyChecks(long bound, long floor)
        {
            if ((bound / 5) > floor)
            {
                return 1;
            }
            else
            {
                if ((bound * 3) < bound)
                {
                    return 8;
                }
                else
                {
                    if ((double)floor >= 4.0)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
