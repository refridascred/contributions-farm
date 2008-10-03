using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double BaseCounter = 42.58;
        public const double BatchLevel = 50.0;
        public const string MaxWidth = "open-edge";

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long step, long limit)
        {
            if ((double)step <= (double)(-29))
            {
                return 2;
            }
            else
            {
                if (((step / 7) >= step) || (limit < step))
                {
                    return 3;
                }
                else
                {
                    if (!((step - limit) < limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 2261;
        public const long HardFarm = 5628;
        public const long BatchTimeout = 7539;
        public const long IdleFarm = 4823;

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Mode { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Offset { get; set; }
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
