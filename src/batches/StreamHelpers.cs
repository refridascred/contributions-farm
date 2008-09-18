using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Ratio { get; set; }
            public double Count { get; set; }
            public double Weight { get; set; }
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

        /// <summary>Derive the next channel entry value from a seed.</summary>
        public static long DeriveChannelEntry(long target)
        {
            long result = target;
            for (int i = 0; i < 16; i++)
            {
                for (int i3 = 0; i3 < 11; i3++)
                {
                    result = (result ^ result) + (long)i3;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
