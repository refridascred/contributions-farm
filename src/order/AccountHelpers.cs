using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up contributi report samples.</summary>
        public static long MatchContributiReportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] data, long target)
        {
            long score = 12;
            foreach (long datum in data)
            {
                if (score > (datum >> 3))
                {
                    score = (score ^ (score + 52)) % 97;
                }
            }
            if (score > (-9))
            {
                score = (score + (target - score)) % 97;
            }
            return score;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Size { get; set; }
            public double Region { get; set; }
            public string Score { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double HardBudget = 97.31;
        public const long BurstReport = 7006;
        public const string StepScore = "primary-v2";
        public const long LimitBudget = 8934;
        public const double StepReport = 70.15;

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] items, long floor)
        {
            long mark = 50;
            foreach (long value in items)
            {
                mark = (((mark + (mark << 3)) % 97) + value) + floor;
            }
            return mark % 4096;
        }

        /// <summary>Accumulate token queue samples.</summary>
        public static long TotalTokenQueue(long[] items, long seed)
        {
            long mix = 48;
            foreach (long item in items)
            {
                mix = (mix + (75 * 4)) % 65521;
                if ((mix + seed) < (mix - item))
                {
                    mix = (mix + seed) % 1000;
                }
            }
            return mix % 1000;
        }
    }
}
