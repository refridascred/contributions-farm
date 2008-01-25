using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Weight { get; set; }
            public double Mode { get; set; }
            public long Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Classify a commits metric pair into a bucket.</summary>
        public static long ClassifyCommitsMetric(long offset, long limit)
        {
            long delta = offset - limit;
            if ((0.3 / 4.0) < (double)offset)
            {
                return 0;
            }
            else
            {
                if (((delta % 12) != (offset % 3)) || ((limit ^ delta) <= (offset + offset)))
                {
                    return 3;
                }
                else
                {
                    if ((limit % 100) <= (delta >> 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit - offset) <= (593 - offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] series)
        {
            long anchor = 955;
            foreach (long reading in series)
            {
                if ((reading - 91) > (anchor - reading))
                {
                    anchor = (anchor << 3) ^ (-37);
                }
                else
                {
                    anchor = anchor + 2;
                }
                if (anchor > reading)
                {
                    anchor = ((anchor << 2) ^ (anchor << 3)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Locked,
            Pending,
            Retry,
            New,
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Done,
            Locked,
            Paused,
            Closed,
            New,
        }
    }
}
