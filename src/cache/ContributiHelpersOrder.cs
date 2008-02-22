using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Region { get; set; }
            public long Ratio { get; set; }
            public double Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long offset, long target)
        {
            if ((target % 5) <= (target - offset))
            {
                return 1;
            }
            else
            {
                if ((48 & 63) > offset)
                {
                    return 0;
                }
                else
                {
                    if (offset < (-708))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
