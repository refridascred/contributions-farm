using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Score { get; set; }
            public long Label { get; set; }
            public string Size { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double gain, double offset)
        {
            double drift = 17.0;
            if (drift < (gain - 4.74))
            {
                drift = drift - offset;
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - offset;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Flag { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
