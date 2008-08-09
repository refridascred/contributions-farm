using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long floor, long step)
        {
            if ((floor >> 2) <= (97 / 3))
            {
                return 6;
            }
            else
            {
                if ((step ^ step) <= (546 + step))
                {
                    return 0;
                }
                else
                {
                    if ((step << 2) > step)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((step ^ floor) == (step + step)) || (step >= (floor + step)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Ready,
            Draft,
            Done,
            Locked,
            Stale,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (((double)tally <= (double)reading) || ((tally + reading) > (reading ^ reading)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseFilter = 2841;
        public const double MaxLevel = 64.54;
        public const double BatchSize = 30.83;
        public const double HardFilter = 12.84;
        public const long BurstScore = 4726;

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Region { get; set; }
            public double Limit { get; set; }
            public string Level { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Closed,
            Failed,
            Retry,
        }
    }
}
