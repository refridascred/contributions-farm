using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Match up metrics notes samples.</summary>
        public static long PairMetricsNotesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long origin, long target)
        {
            if ((target - 82) < (22 * 2))
            {
                return 0;
            }
            else
            {
                if (target <= origin)
                {
                    return 2;
                }
                else
                {
                    if (((target ^ target) >= origin) && ((839 & 255) == (origin + 27)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Stale,
            Idle,
            Synced,
            Ready,
        }
    }
}
