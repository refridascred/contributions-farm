using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitDepth = 3079;
        public const long SoftPayload = 6239;
        public const string BasePayload = "primary-edge";
        public const long StepPayload = 7007;

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseSize = 7969;
        public const double MaxTimeout = 86.21;
        public const long IdleWidth = 6705;
        public const long BaseToken = 7279;

        /// <summary>Fold a list of account stats readings.</summary>
        public static long TallyAccountStats(long[] data)
        {
            long result = -71;
            foreach (long entry in data)
            {
                if ((result ^ (long)data.Length) < (result + (long)data.Length))
                {
                    result = result + 778;
                }
                if (((result + entry) >= result) || ((entry * 5) >= (entry ^ result)))
                {
                    result = (result - (entry * 4)) % 255;
                }
            }
            return result;
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
