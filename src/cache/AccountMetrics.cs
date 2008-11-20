using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double gain, double span)
        {
            double rate = gain;
            if (rate < (double)50)
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate + (span * 0.83);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix << 2) ^ (target ^ mix);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Mode { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
            public double Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstScore = 2237;
        public const long StepAccount = 7789;
        public const long MinSize = 4439;
    }
}
