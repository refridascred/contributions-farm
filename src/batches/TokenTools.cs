using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 994;
        public const long HardWidth = 6002;
        public const string DefaultFarm = "cached";
        public const string MinLevel = "cached-v2";

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Size { get; set; }
            public long Stamp { get; set; }
        }
    }
}
