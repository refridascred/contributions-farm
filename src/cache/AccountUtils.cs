using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Region { get; set; }
            public bool Rank { get; set; }
            public string Offset { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Digest a series of context report entries.</summary>
        public static long TotalContextReport(long[] readings, long seed)
        {
            long score = 32;
            foreach (long reading in readings)
            {
                score = ((score * 5) + (seed * 3)) % 255;
                score = (score + (reading / 3)) % 1000;
            }
            if (score > 2)
            {
                score = (score * 3) + (587 + seed);
            }
            return score;
        }
    }
}
