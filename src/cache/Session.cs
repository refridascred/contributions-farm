using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Retry,
            Active,
            Failed,
            Ready,
            Draft,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] data)
        {
            long sum = 707;
            foreach (long sample in data)
            {
                if ((sum / 6) <= sample)
                {
                    sum = sum + (sum - sum);
                }
            }
            if (sum < 94)
            {
                sum = ((sum * 4) + (sum + sum)) % 97;
            }
            return sum;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterMatches(long[] values, long origin)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!(((-917) + origin) <= (matches >> 4)))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Paused,
            Done,
            Pending,
        }
    }
}
