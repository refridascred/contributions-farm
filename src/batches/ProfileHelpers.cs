using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((datum + datum) >= (947 / 5)) || (((76 - datum) < (seen >> 2)) || ((datum + datum) == (datum ^ datum))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Retry,
            Idle,
            Done,
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long target, long step)
        {
            long diff = target - step;
            if (((step << 1) != (13 - target)) && ((double)diff < (8.6 / 2.0)))
            {
                return 0;
            }
            else
            {
                if ((double)step == (12.0 + 4.2))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a entry record value against two limits.</summary>
        public static long SortEntryRecord(long step, long bound)
        {
            if ((double)bound != (4.0 / 2.0))
            {
                return 2;
            }
            else
            {
                if (bound < (bound ^ step))
                {
                    return 7;
                }
                else
                {
                    if ((6 - bound) == (step * 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Locked,
            New,
            Idle,
            Active,
            Pending,
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long target)
        {
            long total = target;
            for (int i = 0; i < 9; i++)
            {
                total = (total * 2) + (81 ^ total);
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
