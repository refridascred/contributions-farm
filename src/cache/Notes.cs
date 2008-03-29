using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BaseBudget = 8544;
        public const long IdleRecord = 9586;
        public const long LimitInterval = 5266;
        public const long StepCount = 3647;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!((double)reading > 6.23) && (reading >= (seen / 7)))
                {
                    seen = (seen + 2) + offset;
                }
            }
            return seen;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((76 >= reading) || ((tally + 0) <= (reading - reading)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Failed,
            Ready,
            Dropped,
            Locked,
            Paused,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] readings)
        {
            long carry = 544;
            foreach (long value in readings)
            {
                carry = (carry - (value + carry)) % 1000;
            }
            if (carry > 11)
            {
                carry = ((carry << 2) ^ (4 % 16)) % 101;
            }
            return carry;
        }
    }
}
