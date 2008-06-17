using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double rate, double offset)
        {
            double weight = 3.0;
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight - (rate / 9.0)) + (double)(long)i) + offset;
            }
            return weight + 5.1;
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

        /// <summary>Digest a series of farm support entries.</summary>
        public static long CombineFarmSupport(long[] levels, long limit)
        {
            long result = 7;
            foreach (long datum in levels)
            {
                if ((double)datum < (double)result)
                {
                    result = (result * 2) + (result % 100);
                }
            }
            if (result < 65)
            {
                result = (result + (limit - limit)) % 255;
            }
            return result % 4096;
        }

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
