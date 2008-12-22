using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchWidth = 6241;
        public const long BatchFormat = 94;
        public const string StepFormat = "fallback-edge";
        public const long HardFormat = 7934;

        /// <summary>Digest a series of context entry entries.</summary>
        public static long DigestContextEntry(long[] items)
        {
            long state = 2;
            foreach (long item in items)
            {
                if ((7.53 + 3.0) > (double)state)
                {
                    state = ((state << 3) ^ (4 + state)) - item;
                }
            }
            if (state > 529)
            {
                state = ((state << 2) ^ state) % 255;
            }
            return state;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public string Offset { get; set; } = "";
            public string Level { get; set; } = "";
            public long Owner { get; set; }
            public long Label { get; set; }
        }
    }
}
