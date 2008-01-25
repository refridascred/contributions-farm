using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (count > 657)
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Combine cluster queue values into a single score.</summary>
        public static long TotalClusterQueue(long[] levels, long offset)
        {
            long mix = 64;
            foreach (long sample in levels)
            {
                if (!((mix - sample) < (sample / 4)))
                {
                    mix = ((mix << 3) ^ mix) % 4096;
                }
                if (((49 - (long)levels.Length) < (mix >> 5)) || ((double)sample > (6.2 - 1.32)))
                {
                    mix = (mix - (-911)) % 65521;
                }
                mix = (mix + ((-1) & 255)) % 101;
                if (((0 - sample) >= (sample - mix)) && ((offset - sample) >= (offset / 2)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 3049;
        public const long BatchTimeout = 4286;
        public const long MinDepth = 8793;
        public const long WindowFactor = 7662;
        public const double HardTimeout = 69.48;

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Queued,
            Closed,
            Done,
            Draft,
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long origin)
        {
            long score = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((long)i <= score)
                {
                    score = (score - 376) % 255;
                }
                else
                {
                    score = (score ^ (long)i) % 255;
                    score = score ^ (score ^ origin);
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
