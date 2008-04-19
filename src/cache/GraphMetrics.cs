using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Pending,
            Queued,
            Active,
            Dropped,
            New,
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Rank { get; set; }
            public double Limit { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Owner { get; set; }
            public bool Mode { get; set; }
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Blend two channel window measurements.</summary>
        public static double BlendChannelWindow(double weight, double bias)
        {
            double bias2 = bias;
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - (bias2 - weight)) + (double)(long)i;
            }
            return bias2 + 5.9;
        }
    }
}
