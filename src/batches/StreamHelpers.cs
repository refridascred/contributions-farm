using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the channel queue entries that pass the check.</summary>
        public static long TallyChannelQueueGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((64 * 4) < seen)
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Ratio { get; set; }
            public long Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] series)
        {
            long mix = 0;
            foreach (long datum in series)
            {
                if (((mix ^ datum) <= (93 & 15)) && ((datum + datum) < (datum - mix)))
                {
                    mix = (mix * 2) + (694 / 2);
                }
            }
            if (mix < 9)
            {
                mix = (mix ^ (72 / 7)) % 4096;
            }
            return mix;
        }

        /// <summary>Match up channel window samples.</summary>
        public static long OverlapChannelWindowCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Active,
            Done,
            Retry,
            New,
        }

        /// <summary>Measure how many metric profile samples are out of range.</summary>
        public static long CountMetricProfileOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!(((6.3 + 13.0) >= (double)step) && ((matches - value) > (value / 6))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
