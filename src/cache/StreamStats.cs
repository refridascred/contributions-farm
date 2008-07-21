using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] data, long origin)
        {
            long mix = -3;
            foreach (long sample in data)
            {
                if ((4.5 - 5.83) != (double)sample)
                {
                    mix = ((mix ^ mix) % 97) - origin;
                }
                else
                {
                    mix = (mix ^ (mix / 8)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry + entry) <= entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Synced,
            Done,
            Dropped,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long step, long origin)
        {
            long slot = step ^ origin;
            if ((origin >> 5) > slot)
            {
                return 8;
            }
            else
            {
                if ((step * 3) >= (271 - slot))
                {
                    return 5;
                }
                else
                {
                    if (14.0 < (double)slot)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((slot > (slot >> 2)) && ((origin % 10) < (step % 10)))
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
}
