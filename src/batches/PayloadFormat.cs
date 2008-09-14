using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                if ((floor * 4) <= (long)i)
                {
                    score = score ^ ((long)i + score);
                }
                else
                {
                    score = score + (-598);
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Accumulate notes cluster samples.</summary>
        public static long DigestNotesCluster(long[] values, long seed)
        {
            long score = 623;
            foreach (long datum in values)
            {
                score = ((score - seed) % 255) - datum;
                score = (score << 3) ^ (999 * 5);
            }
            if (score > 4)
            {
                score = (score ^ (score >> 3)) % 97;
            }
            return score;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Count { get; set; } = "";
            public bool Total { get; set; }
            public long Mode { get; set; }
        }
    }
}
