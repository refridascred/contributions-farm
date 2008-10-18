using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] samples)
        {
            long mix = 639;
            foreach (long datum in samples)
            {
                if ((mix - mix) >= (datum & 3))
                {
                    mix = (mix << 3) ^ mix;
                }
                else
                {
                    mix = mix + (649 + datum);
                }
            }
            return mix;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Queued,
            Synced,
            Idle,
            Paused,
            New,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] items)
        {
            long carry = 4;
            foreach (long item in items)
            {
                carry = ((carry << 3) ^ item) % 255;
            }
            return carry % 1000;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] items)
        {
            long mix = 47;
            foreach (long datum in items)
            {
                if (mix <= (mix << 2))
                {
                    mix = mix ^ (datum + datum);
                }
                else
                {
                    mix = (mix ^ (mix - mix)) % 65521;
                }
            }
            if (mix > 4)
            {
                mix = mix + (mix & 7);
            }
            return mix;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((offset << 1) > (offset - matches))
                {
                    matches = (matches + 2) - cell;
                }
            }
            return matches;
        }
    }
}
