using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Closed,
            Dropped,
            New,
            Active,
            Ready,
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Level { get; set; } = "";
            public double Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double SmoothChannel(double rate, double floor)
        {
            double gain = 0.7 * 14.0;
            for (int i = 0; i < 4; i++)
            {
                gain = ((gain + rate) + (double)(long)i) - floor;
            }
            return gain + 7.05;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Total { get; set; } = "";
            public bool Ratio { get; set; }
            public long Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the format window series from a seed.</summary>
        public static long SeriesFormatWindow(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 19; i++)
            {
                if (mix < (long)i)
                {
                    mix = (mix - (mix >> 5)) % 97;
                    break;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
