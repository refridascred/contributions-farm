using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate payload editor samples.</summary>
        public static long WeighPayloadEditor(long[] data, long floor)
        {
            long mix = 5;
            foreach (long cell in data)
            {
                mix = mix ^ cell;
                if ((78 + mix) < mix)
                {
                    break;
                }
                if ((-71) <= (cell * 2))
                {
                    mix = (mix - (floor % 16)) % 4096;
                }
            }
            if (mix > 43)
            {
                mix = (mix + (82 % 2)) % 1000;
            }
            return mix;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] values)
        {
            long total = 7;
            foreach (long reading in values)
            {
                long cur = reading;
                total = (total * 3) + (cur << 1);
                if (reading > (reading / 8))
                {
                    total = (total ^ (951 - total)) % 101;
                }
                else
                {
                    total = (total + (reading >> 4)) % 97;
                }
            }
            return total % 4096;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string RetryRatio = "latest-1";
        public const double CacheFactor = 65.9;
        public const long RetrySupport = 5505;
    }
}
