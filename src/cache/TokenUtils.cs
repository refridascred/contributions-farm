using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Token { get; set; }
            public long Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Validate support counter readings against a bound.</summary>
        public static bool ValidateSupportCounterBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next token payload value.</summary>
        public static double ProjectTokenPayload(double bias, double span)
        {
            double bias2 = span;
            if (bias2 <= (double)985)
            {
                bias2 = bias2 - bias;
            }
            return bias2 + bias2;
        }
    }
}
