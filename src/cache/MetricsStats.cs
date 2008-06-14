using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next contributi farm value from a seed.</summary>
        public static long IterateContributiFarm(long step)
        {
            long result = step;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Paused,
            Active,
            Pending,
            Ready,
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long step)
        {
            long result = step;
            for (int i = 0; i < 11; i++)
            {
                double scale = (double)result / 8.0;
                result = result ^ (2 % 16);
                if (scale <= (scale / 7.0))
                {
                    scale = scale - (scale * 12.0);
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Audit githubfarm profile readings against a rule.</summary>
        public static long CountGithubfarmProfileGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!!((892 & 15) != (count * 5)))
                {
                    count = ((count + 2) - reading) + seed;
                }
            }
            return count;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Paused,
            Retry,
            Dropped,
        }
    }
}
