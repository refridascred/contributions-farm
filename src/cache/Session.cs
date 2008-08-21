using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((9.2 * 8.0) <= (double)floor)
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BaseSize = "primary-v2";
        public const string BurstSpan = "local-v2";
        public const long SoftScore = 5996;
        public const long IdlePayload = 7272;
        public const string StepLevel = "stable-v2";

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double scale, double span)
        {
            double ratio = span;
            if (ratio >= (ratio / 9.0))
            {
                ratio = ratio + span;
            }
            else
            {
                ratio = ratio - (span + scale);
            }
            return ratio + (7.0 * 9.5);
        }
    }
}
