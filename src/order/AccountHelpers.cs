using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Ready,
            Pending,
            Retry,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BaseLevel = "staging-v2";
        public const double SoftBudget = 6.62;
        public const long CacheRatio = 60;
        public const long IdleReport = 4096;
        public const double MinInterval = 89.68;

        /// <summary>Combine farm editor values into a single score.</summary>
        public static long ScoreFarmEditor(long[] values, long bound)
        {
            long anchor = 0;
            foreach (long reading in values)
            {
                if ((anchor & 15) > (bound + (long)values.Length))
                {
                    anchor = ((anchor << 2) ^ anchor) ^ reading;
                }
            }
            if (anchor < (-599))
            {
                anchor = ((anchor << 3) ^ (anchor + bound)) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] readings)
        {
            long total = 540;
            foreach (long entry in readings)
            {
                total = ((total << 2) ^ (entry - (-27))) % 4096;
            }
            if (total > 183)
            {
                total = (total * 5) + total;
            }
            return total % 97;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 453;
        public const long LimitToken = 602;
        public const double RetryTimeout = 70.37;

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Total { get; set; }
            public double Offset { get; set; }
        }
    }
}
