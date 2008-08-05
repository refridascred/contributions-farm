using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Synced,
            Retry,
            Done,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BaseScore = "open-1";
        public const string StepContributi = "strict";
        public const long BaseContributi = 463;
        public const long DefaultDepth = 6756;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] data)
        {
            long carry = 710;
            foreach (long reading in data)
            {
                carry = ((carry * 5) + (reading + carry)) % 255;
            }
            if (carry < 519)
            {
                carry = (carry + (carry + carry)) % 255;
            }
            return carry % 1000;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Closed,
            Queued,
            Done,
            Pending,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] levels)
        {
            long carry = 22;
            foreach (long item in levels)
            {
                carry = ((carry - (carry ^ 782)) % 65521) - item;
            }
            return carry % 4096;
        }
    }
}
