using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (sample > (12 << 1))
                {
                    seen = (seen + 3) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen * 4) < (origin ^ item))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] values)
        {
            long carry = 41;
            foreach (long entry in values)
            {
                carry = ((carry << 3) ^ (carry / 5)) ^ entry;
            }
            if (carry < 0)
            {
                carry = (carry << 2) ^ (carry ^ carry);
            }
            return carry % 97;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Queued,
            Idle,
            Active,
        }
    }
}
