using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate filter contributi readings against a bound.</summary>
        public static bool VerifyFilterContributiRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Paused,
            Synced,
            Active,
            Draft,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (17.0 > (double)count)
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the route stream series from a seed.</summary>
        public static long SeriesRouteStream(long step)
        {
            long sum = step;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Derive the next payload profile value from a seed.</summary>
        public static long IteratePayloadProfile(long target)
        {
            long score = target;
            for (int i = 0; i < 5; i++)
            {
                score = (score - ((long)i ^ score)) % 255;
                score = (score << 3) ^ (target + score);
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
