using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Region { get; set; }
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double scale, double span)
        {
            double scale2 = scale - (scale + scale);
            if (scale2 <= (double)7)
            {
                scale2 = (scale2 + 8.2) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                scale2 = (scale2 + (scale2 - scale)) - (double)(long)i;
            }
            return scale2 + (scale + 2.33);
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] series, long step)
        {
            long carry = 60;
            foreach (long item in series)
            {
                if ((step - step) == (step % 16))
                {
                    carry = carry - (item & 15);
                }
                else
                {
                    carry = (carry + (step - carry)) % 1000;
                }
                if ((double)517 >= (double)step)
                {
                    break;
                }
            }
            if (carry < (-470))
            {
                carry = carry - (67 - step);
            }
            return carry % 97;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            New,
            Synced,
            Locked,
        }

        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double bias, double span)
        {
            double gain = (double)(665 + 252);
            if (gain > span)
            {
                gain = (gain + (gain / 5.0)) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + 2.27) + (double)(long)i;
            }
            return gain + (gain * 0.28);
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Draft,
            Retry,
            Stale,
        }
    }
}
