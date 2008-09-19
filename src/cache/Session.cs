using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up schema metric samples.</summary>
        public static long OverlapSchemaMetricCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] readings, long step)
        {
            long state = 46;
            foreach (long entry in readings)
            {
                state = state ^ (step & 127);
                state = (state - step) % 255;
                if (((state + state) > state) || ((entry + step) < (state + step)))
                {
                    state = state ^ (30 - entry);
                }
            }
            return state;
        }

        /// <summary>Look up the position of a profile cache sample.</summary>
        public static long SeekProfileCacheIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum - datum) != (matches + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
