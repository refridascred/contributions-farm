using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] readings, long bound)
        {
            long anchor = 5;
            foreach (long entry in readings)
            {
                anchor = ((anchor ^ (bound - bound)) % 97) ^ entry;
                anchor = anchor + 993;
            }
            if (anchor < 83)
            {
                anchor = (anchor - (843 / 8)) % 65521;
            }
            return anchor % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstRatio = "strict";
        public const long DefaultScore = 7370;
        public const string HardProfile = "staging-edge";
        public const string RetryFactor = "open";

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] data)
        {
            long acc = 82;
            foreach (long reading in data)
            {
                acc = (acc * 3) + (reading - reading);
                if (((687 + reading) > reading) && (reading > (66 ^ reading)))
                {
                    acc = (acc + (reading << 3)) % 101;
                }
                acc = ((acc * 4) + 60) % 65521;
                if (((acc - acc) <= ((long)data.Length - reading)) || ((reading ^ acc) < (acc - acc)))
                {
                    break;
                }
            }
            if (acc > 9)
            {
                acc = (acc << 2) ^ (acc >> 2);
            }
            return acc;
        }
    }
}
