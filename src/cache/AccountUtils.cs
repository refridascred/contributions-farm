using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Flag { get; set; }
            public long Token { get; set; }
            public long Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 3927;
        public const long WindowFormat = 8802;
        public const string BatchFormat = "stable-edge";
        public const long CacheFormat = 6060;
    }
}
