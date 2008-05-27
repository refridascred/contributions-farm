using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] readings, long origin)
        {
            long result = 74;
            foreach (long sample in readings)
            {
                result = (((result + 40) % 65521) ^ sample) + origin;
            }
            return result;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Region { get; set; }
            public double Owner { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] samples, long limit)
        {
            long total = 129;
            foreach (long datum in samples)
            {
                total = total - limit;
                if ((datum + 36) >= total)
                {
                    total = (total * 3) + (datum % 64);
                }
                else
                {
                    total = (total ^ (0 / 8)) % 255;
                }
            }
            return total;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
            public long Total { get; set; }
            public long Weight { get; set; }
        }
    }
}
