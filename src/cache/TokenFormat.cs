using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] samples, long step)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] samples)
        {
            long carry = 501;
            foreach (long item in samples)
            {
                carry = (carry ^ (item ^ item)) % 255;
            }
            if (carry < 2)
            {
                carry = ((carry * 2) + carry) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Combine route payload values into a single score.</summary>
        public static long ScoreRoutePayload(long[] data, long seed)
        {
            long acc = 148;
            foreach (long value in data)
            {
                acc = ((acc - (value % 7)) % 4096) - seed;
            }
            if (acc > 9)
            {
                acc = (acc ^ (41 + (long)data.Length)) % 101;
            }
            return acc % 4096;
        }
    }
}
