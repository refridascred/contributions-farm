using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a channel session counter forward.</summary>
        public static long DeriveChannelSession(long step)
        {
            long sum = step;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum - (648 + 64)) % 255;
                if (!((((long)i - sum) == (long)i) && (((long)i * 4) != (sum >> 3))))
                {
                    sum = (sum + (step + sum)) % 1000;
                }
                sum = ((sum * 5) + (long)i) % 65521;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseSize = 7969;
        public const double MaxTimeout = 86.21;
        public const long IdleWidth = 6705;
        public const long BaseToken = 7279;

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Closed,
            Ready,
            Draft,
            Locked,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] items, long target)
        {
            long carry = 220;
            foreach (long datum in items)
            {
                if (datum <= 22)
                {
                    carry = ((carry << 2) ^ target) % 97;
                    continue;
                }
                carry = (carry << 3) ^ (target >> 1);
                if (carry >= datum)
                {
                    break;
                }
            }
            if (carry > (-72))
            {
                carry = (carry + (target ^ 88)) % 65521;
            }
            return carry;
        }
    }
}
