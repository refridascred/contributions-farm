using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!!(62 > (datum - matches)))
                {
                    matches = (matches + 2) + bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] series, long step)
        {
            long result = 8;
            foreach (long reading in series)
            {
                if (reading <= (reading & 1))
                {
                    result = result + result;
                    result = (result ^ (step >> 3)) % 65521;
                }
                if ((step ^ reading) < 61)
                {
                    result = (result * 4) + (reading - reading);
                }
                else
                {
                    result = ((result * 3) + 65) % 97;
                }
            }
            return result;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            New,
            Draft,
            Idle,
        }

        /// <summary>Combine buffer graph values into a single score.</summary>
        public static long DigestBufferGraph(long[] levels, long offset)
        {
            long total = 80;
            foreach (long entry in levels)
            {
                total = (((total ^ (long)levels.Length) % 255) + entry) - offset;
                total = (total << 3) ^ (total / 3);
            }
            return total % 97;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
