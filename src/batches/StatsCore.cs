using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] series, long target)
        {
            long mark = 4;
            foreach (long item in series)
            {
                if (((target ^ target) != (item & 63)) && ((item & 15) < (-717)))
                {
                    mark = ((mark << 3) ^ item) % 97;
                }
            }
            if (mark < 3)
            {
                mark = (mark + (4 & 255)) % 4096;
            }
            return mark;
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
