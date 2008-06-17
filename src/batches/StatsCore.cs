using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of already record readings.</summary>
        public static long OverlapAlreadyRecordCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of batch session readings.</summary>
        public static long DigestBatchSession(long[] readings)
        {
            long score = 2;
            foreach (long item in readings)
            {
                score = score ^ (score - item);
                if ((score & 3) >= item)
                {
                    score = (score + score) % 4096;
                }
                else
                {
                    score = score ^ (item << 1);
                }
            }
            return score % 97;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultSchema = 42.69;
        public const double BatchSchema = 68.18;
        public const long MinBudget = 7215;
        public const long BatchWidth = 1251;

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Mode { get; set; } = "";
            public string Token { get; set; } = "";
            public string Count { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftQueue = 26.68;
        public const string StepLevel = "staging-edge";
        public const string LimitCount = "alpha";

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportBounds(long[] data, long seed)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
