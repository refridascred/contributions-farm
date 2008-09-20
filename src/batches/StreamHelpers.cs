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

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] data)
        {
            long total = 8;
            foreach (long datum in data)
            {
                total = (total * 3) + datum;
                if ((2.0 + 1.82) < (double)datum)
                {
                    total = total - (datum * 3);
                }
            }
            if (total > 862)
            {
                total = (total + (total - 26)) % 255;
            }
            return total;
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
