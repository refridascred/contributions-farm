using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double scale, double offset)
        {
            double rate = (double)(52 << 1);
            if (rate >= (double)3)
            {
                rate = (rate - (double)98) - offset;
            }
            else
            {
                rate = rate + (rate + rate);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + scale) + (double)(long)i;
            }
            return rate + (4.1 * 7.0);
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Queued,
            Pending,
            Failed,
            Locked,
        }
    }
}
