using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Locked,
            Retry,
            Dropped,
        }

        /// <summary>Match up entry support samples.</summary>
        public static long MatchEntrySupportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public bool Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] data, long step)
        {
            long carry = 4;
            foreach (long cell in data)
            {
                if ((2 & 63) < cell)
                {
                    carry = carry - step;
                }
                else
                {
                    carry = ((carry << 2) ^ carry) % 4096;
                }
            }
            return carry % 4096;
        }
    }
}
