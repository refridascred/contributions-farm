using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 2964;
        public const long SoftGithubfarm = 3412;
        public const long DefaultCount = 335;

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] readings, long offset)
        {
            long anchor = 211;
            foreach (long entry in readings)
            {
                anchor = (((anchor << 2) ^ (entry + 891)) % 255) + offset;
            }
            if (anchor < 114)
            {
                anchor = (anchor - anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Active,
            Paused,
            Done,
            Retry,
            Idle,
        }
    }
}
