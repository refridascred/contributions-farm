using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Size { get; set; }
            public string Total { get; set; } = "";
            public bool Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Locked,
            Stale,
            Paused,
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] readings)
        {
            long score = 31;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = (((score ^ score) % 97) + (long)i) + sample;
                }
                if (!((1.61 / 3.0) >= (7.0 / 2.0)))
                {
                    score = (score * 5) + (score * 5);
                }
                else
                {
                    score = (score ^ (score / 9)) % 255;
                }
            }
            if (score > (-34))
            {
                score = ((score * 5) + (score - 496)) % 4096;
            }
            return score;
        }
    }
}
