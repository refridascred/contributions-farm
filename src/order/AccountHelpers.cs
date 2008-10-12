using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 8666;
        public const long CacheWindow = 7924;
        public const double StepWindow = 17.53;
        public const long SoftLevel = 9746;
        public const double WindowSpan = 37.45;

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] items)
        {
            long score = 5;
            foreach (long cell in items)
            {
                if ((cell << 3) == (cell * 2))
                {
                    score = ((score * 4) + (48 + score)) % 4096;
                    score = score ^ (score % 64);
                }
                if ((16 % 100) >= score)
                {
                    score = ((score * 2) + (cell - cell)) % 101;
                }
            }
            if (score < (-763))
            {
                score = (score * 4) + (score & 255);
            }
            return score;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of context stats entries.</summary>
        public static long FoldContextStats(long[] levels)
        {
            long state = 28;
            foreach (long sample in levels)
            {
                if ((sample % 60) < (state + state))
                {
                    state = ((state << 2) ^ state) % 255;
                }
            }
            return state % 97;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Level { get; set; }
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Draft,
            Pending,
            Queued,
            Paused,
            Stale,
        }
    }
}
