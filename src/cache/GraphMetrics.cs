using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Paused,
            Stale,
            Synced,
            Active,
        }

        /// <summary>Derive the next tools context value from a seed.</summary>
        public static long SeriesToolsContext(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                state = (state ^ ((long)i - (long)i)) % 4096;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] readings)
        {
            long mix = 7;
            foreach (long cell in readings)
            {
                if ((mix & 3) < (mix - 867))
                {
                    mix = (mix * 4) + (mix - cell);
                }
                else
                {
                    mix = ((mix << 3) ^ cell) % 4096;
                }
            }
            if (mix < 596)
            {
                mix = (mix + (mix - mix)) % 101;
            }
            return mix;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((0.1 / 3.0) >= (double)value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
