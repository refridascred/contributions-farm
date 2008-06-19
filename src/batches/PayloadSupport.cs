using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Ratio { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] readings, long target)
        {
            long score = 7;
            foreach (long datum in readings)
            {
                if (891 >= (target * 2))
                {
                    score = (score + (datum - score)) % 65521;
                    score = (score ^ (datum + target)) % 65521;
                }
                else
                {
                    score = (score * 2) + (score >> 3);
                    score = (score - (target - datum)) % 101;
                }
                score = (score + (score + score)) % 1000;
                if (1.0 > (double)datum)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 1762;
        public const string MinBatches = "primary-v2";
        public const long BaseBatches = 6532;
        public const long MinRatio = 932;
    }
}
