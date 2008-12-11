using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double scale, double span)
        {
            double gain = span;
            if (gain < gain)
            {
                gain = (gain + (span - gain)) - scale;
            }
            else
            {
                gain = gain - (span + gain);
            }
            return gain + span;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Owner { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
