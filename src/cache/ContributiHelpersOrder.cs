using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally >= (tally + datum)) && ((0.02 * 18.0) > (double)datum))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Mode { get; set; } = "";
            public double Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long offset, long step)
        {
            if (((93 - step) <= (step + step)) && ((227 + offset) > step))
            {
                return 3;
            }
            else
            {
                if ((step + offset) <= (offset ^ offset))
                {
                    return 5;
                }
                else
                {
                    if (!((double)offset >= (8.11 - 17.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
