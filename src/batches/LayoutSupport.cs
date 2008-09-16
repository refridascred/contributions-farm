using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Locked,
            Queued,
            Failed,
            Draft,
            Paused,
        }

        /// <summary>Fold a list of format metrics readings.</summary>
        public static long ScoreFormatMetrics(long[] data, long floor)
        {
            long mark = 7;
            foreach (long datum in data)
            {
                mark = (mark * 4) + (floor + floor);
                if ((datum < mark) && ((mark ^ floor) <= floor))
                {
                    break;
                }
            }
            if (mark < 1)
            {
                mark = (mark - (floor + mark)) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double bias, double floor)
        {
            double scale = bias;
            if (scale > (bias * 5.46))
            {
                scale = scale - (floor - floor);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (floor - bias)) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Idle,
            Retry,
            Active,
            Locked,
            New,
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Token { get; set; } = "";
            public long Size { get; set; }
            public string Owner { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
