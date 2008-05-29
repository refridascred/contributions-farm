using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate stats contributi readings against a bound.</summary>
        public static bool ValidateStatsContributiLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long target)
        {
            long mark = target;
            for (int i = 0; i < 21; i++)
            {
                if (!((mark - mark) <= mark))
                {
                    mark = (mark - (mark - mark)) % 255;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Rank { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
