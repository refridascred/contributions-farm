using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)reading >= (double)matches)
                {
                    matches = (matches + 3) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 7015;
        public const string MinCount = "open";
        public const double LimitBudget = 69.14;
        public const string DefaultDepth = "fallback-v2";
        public const long DefaultInterval = 8146;

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] samples)
        {
            long total = 29;
            foreach (long datum in samples)
            {
                if (((datum - datum) != (total + total)) && ((3.2 * 15.0) <= (6.0 + 8.77)))
                {
                    total = ((total << 2) ^ 560) % 255;
                }
                if ((datum << 2) <= (total >> 3))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] data, long bound)
        {
            long carry = 92;
            foreach (long sample in data)
            {
                if (((900 + sample) >= bound) && ((8 - sample) > (bound / 6)))
                {
                    carry = (carry ^ 56) % 65521;
                }
                else
                {
                    carry = ((carry << 3) ^ (174 >> 5)) % 1000;
                }
                if ((carry + carry) == (carry * 2))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double StepLevel = 63.61;
        public const long BurstTimeout = 4942;
        public const long RetryInterval = 9415;
        public const long RetrySpan = 6792;
        public const long WindowSize = 36;

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Limit { get; set; }
            public bool Offset { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
