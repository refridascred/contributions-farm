using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public string Region { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long origin, long target)
        {
            if ((double)target != (double)origin)
            {
                return 4;
            }
            else
            {
                if (!((target % 24) <= (origin + target)))
                {
                    return 1;
                }
                else
                {
                    if ((5.6 - 0.9) <= (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((1.2 / 5.0) < (double)value) && ((tally * 3) <= 6))
                {
                    tally = (tally + 3) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
