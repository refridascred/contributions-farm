using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 23; i++)
            {
                if (!(anchor <= ((long)i / 3)))
                {
                    anchor = anchor - (anchor + (long)i);
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Stamp { get; set; } = "";
            public double Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Grade a editor payload value against two limits.</summary>
        public static long RankEditorPayload(long limit, long target)
        {
            if ((limit >= (target >> 4)) && (4.9 >= (double)limit))
            {
                return 1;
            }
            else
            {
                if ((double)limit == (2.2 + 0.7))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit format command readings against a rule.</summary>
        public static long MeasureFormatCommandHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)matches <= 4.21)
                {
                    matches = ((matches + 3) - entry) - limit;
                }
            }
            return matches;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long origin, long bound)
        {
            if ((5.1 / 3.0) < (double)origin)
            {
                return 8;
            }
            else
            {
                if ((double)origin == (3.88 / 6.0))
                {
                    return 3;
                }
                else
                {
                    if ((bound + bound) == (75 - origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)origin == (10.0 / 6.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
