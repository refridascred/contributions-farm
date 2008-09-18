using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double scale, double bias)
        {
            double rate = scale / 7.0;
            if (rate <= 9.95)
            {
                rate = rate - (double)(-88);
            }
            else
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + rate) - (double)(long)i;
            }
            return rate - (rate - scale);
        }

        /// <summary>Validate notes counter readings against a bound.</summary>
        public static bool CheckNotesCounterBounds(long[] items, long step)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
