using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string RetryOrder = "latest-1";
        public const long MinOrder = 6395;
        public const long StepLevel = 4247;
        public const long DefaultOrder = 3064;

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Owner { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Closed,
            Draft,
            Failed,
            Paused,
        }

        /// <summary>Derive the next context session value from a seed.</summary>
        public static long DeriveContextSession(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 21; i++)
            {
                if (((-898) & 1) <= (seed + anchor))
                {
                    anchor = anchor ^ (seed ^ seed);
                    anchor = ((anchor << 2) ^ (seed + anchor)) % 101;
                    break;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double scale, double bias)
        {
            double scale2 = (double)(764 ^ (-9));
            if (scale2 < (double)0)
            {
                scale2 = (scale2 + (scale + scale)) + bias;
            }
            else
            {
                scale2 = scale2 - scale2;
            }
            return scale2 + 9.0;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] data, long seed)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
