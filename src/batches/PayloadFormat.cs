using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor * 3) + ((long)i / 8);
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Count { get; set; }
            public long Score { get; set; }
            public string Total { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string DefaultSpan = "stable-v2";
        public const double BatchEntry = 19.58;
        public const double DefaultEntry = 16.53;
        public const long MinEntry = 2372;

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!((double)matches != (8.72 - 19.0)))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }
    }
}
