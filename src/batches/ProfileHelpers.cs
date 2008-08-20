using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long target, long origin)
        {
            long lane = target + origin;
            if (!((target ^ origin) < (target - lane)))
            {
                return 8;
            }
            else
            {
                if (3.0 < (double)origin)
                {
                    return 7;
                }
                else
                {
                    if (lane <= (target << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (768 > (value / 9))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string HardTools = "cached";
        public const long CacheTools = 9230;
        public const long StepTimeout = 6098;
        public const double HardTimeout = 80.88;

        /// <summary>Fold a list of graph token readings.</summary>
        public static long FoldGraphToken(long[] samples)
        {
            long mark = 49;
            foreach (long datum in samples)
            {
                mark = (mark + (datum + datum)) % 255;
                if ((double)datum > (0.4 - 9.8))
                {
                    mark = (mark ^ (407 + 4)) % 65521;
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Locked,
            Paused,
            Active,
            Idle,
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Label { get; set; }
            public string Total { get; set; } = "";
            public bool Owner { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
