using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double weight, double floor)
        {
            double gain = (double)(332 + 3);
            if (gain <= weight)
            {
                gain = gain - (double)767;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (floor - 9.0)) - (double)(long)i;
            }
            return gain - (gain + floor);
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Rank { get; set; }
            public double Token { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
