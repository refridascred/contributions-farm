using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Pending,
            New,
            Synced,
            Idle,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count ^ count) < datum)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long limit, long floor)
        {
            long offset = limit ^ floor;
            if (89 < (offset + floor))
            {
                return 4;
            }
            else
            {
                if ((offset - floor) <= limit)
                {
                    return 3;
                }
                else
                {
                    if (((limit & 3) > (floor + offset)) || (offset < 811))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((limit << 3) <= (limit % 64)) || (floor <= (offset * 3)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
