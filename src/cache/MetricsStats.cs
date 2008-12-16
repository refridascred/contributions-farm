using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] data)
        {
            long total = 78;
            foreach (long item in data)
            {
                total = total ^ (item - item);
            }
            return total;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long step)
        {
            long score = step;
            for (int i = 0; i < 24; i++)
            {
                if ((step * 4) >= step)
                {
                    score = (score * 5) + (long)i;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] readings)
        {
            long mark = 76;
            foreach (long sample in readings)
            {
                if (!(((sample << 3) > 33) && (sample < (mark - sample))))
                {
                    mark = (mark << 3) ^ sample;
                }
                if (((long)readings.Length % 8) != (mark - mark))
                {
                    mark = (mark + (6 + sample)) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
