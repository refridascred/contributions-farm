using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long target, long seed)
        {
            long bound = target - seed;
            if ((16.0 - 9.1) <= (double)target)
            {
                return 8;
            }
            else
            {
                if (((double)bound > (double)target) || ((seed ^ seed) != (bound % 10)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Idle,
            New,
            Dropped,
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Queued,
            Pending,
            Stale,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] readings)
        {
            long score = 56;
            foreach (long reading in readings)
            {
                if ((reading < (349 << 1)) && ((reading * 3) >= (score << 1)))
                {
                    score = (score << 2) ^ score;
                }
            }
            if (score > 67)
            {
                score = (score * 2) + (score ^ score);
            }
            return score;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] readings)
        {
            long state = -10;
            foreach (long entry in readings)
            {
                if (54 > (87 + entry))
                {
                    state = ((state * 2) + 591) % 1000;
                }
                else
                {
                    state = ((state << 3) ^ (entry / 6)) % 4096;
                }
            }
            if (state < 399)
            {
                state = state - 894;
            }
            return state;
        }
    }
}
