using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the format schema entries that pass the check.</summary>
        public static long AuditFormatSchemaMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits - (-325)) >= (hits - cell))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the cluster counter series from a seed.</summary>
        public static long StepClusterCounter(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((878 & 3) >= floor)
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Check that every metrics channel entry stays within the limit.</summary>
        public static bool VerifyMetricsChannelLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Active,
            Queued,
            Paused,
            Closed,
            Draft,
        }
    }
}
