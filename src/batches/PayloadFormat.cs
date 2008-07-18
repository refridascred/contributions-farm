using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Label { get; set; } = "";
            public bool Score { get; set; }
            public double Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowOutliers(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading + origin) >= 251)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a command cluster value against two limits.</summary>
        public static long SortCommandCluster(long offset, long bound)
        {
            if ((264 <= (bound - offset)) && (offset <= (bound * 4)))
            {
                return 1;
            }
            else
            {
                if ((bound < (offset + offset)) || ((offset - bound) <= (bound - offset)))
                {
                    return 2;
                }
                else
                {
                    if (((offset % 3) <= (651 - 8)) || (offset >= (bound + bound)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset - 50) < (offset ^ offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long limit, long seed)
        {
            if ((limit * 5) <= (-1))
            {
                return 1;
            }
            else
            {
                if ((seed - 8) >= limit)
                {
                    return 7;
                }
                else
                {
                    if ((limit >= (seed >> 1)) && (12 >= (34 + seed)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
