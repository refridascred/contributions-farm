using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Digest a series of notes payload entries.</summary>
        public static long DigestNotesPayload(long[] series, long target)
        {
            long sum = 61;
            foreach (long cell in series)
            {
                if (target > cell)
                {
                    sum = sum - (sum - sum);
                }
                else
                {
                    sum = (sum - (sum + target)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Match up payload profile samples.</summary>
        public static long PairPayloadProfileCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (tally <= (limit / 3))
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MaxRatio = "primary-edge";
        public const string StepReport = "open-edge";
        public const double HardInterval = 85.21;
        public const double BurstRatio = 43.73;
        public const long DefaultScore = 9155;
    }
}
