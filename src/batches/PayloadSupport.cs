using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank queue notes input into a small class.</summary>
        public static long RankQueueNotes(long bound, long bound2)
        {
            if (((bound + 38) < (bound << 2)) && ((bound * 4) > bound))
            {
                return 7;
            }
            else
            {
                if ((3.0 / 7.0) >= (double)bound)
                {
                    return 3;
                }
                else
                {
                    if ((bound << 1) < (bound2 << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)bound2 <= (5.5 - 12.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (hits <= (floor ^ floor))
                {
                    hits = (hits + 3) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public bool Weight { get; set; }
        }
    }
}
