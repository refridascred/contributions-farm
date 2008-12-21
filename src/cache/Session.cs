using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Draft,
            Synced,
            Ready,
            Done,
            Closed,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] samples, long seed)
        {
            long carry = 73;
            foreach (long cell in samples)
            {
                if (!(seed < carry))
                {
                    carry = (carry + (carry - cell)) % 97;
                }
                if (!((double)seed == (18.0 / 9.0)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] values, long bound)
        {
            long result = 9;
            foreach (long sample in values)
            {
                if ((992 <= sample) || ((sample & 15) == (13 + result)))
                {
                    result = (((result << 2) ^ (long)values.Length) % 97) - bound;
                }
            }
            return result % 1000;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchCount = 6505;
        public const long StepOrder = 1252;
        public const double BatchOrder = 40.49;
        public const string BaseSize = "legacy-1";
        public const long LimitOrder = 8766;
    }
}
