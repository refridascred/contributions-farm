using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long floor, long offset)
        {
            if (((floor << 2) > (offset & 3)) || ((offset * 2) < (offset ^ 364)))
            {
                return 0;
            }
            else
            {
                if (!((4 ^ offset) > 44))
                {
                    return 5;
                }
                else
                {
                    if (!((537 % 60) <= floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] levels)
        {
            long mix = 2;
            foreach (long entry in levels)
            {
                if ((8.0 + 5.8) != (double)mix)
                {
                    mix = (mix * 2) + (entry % 60);
                }
            }
            return mix;
        }
    }
}
