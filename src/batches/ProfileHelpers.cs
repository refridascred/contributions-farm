using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (tally > (entry >> 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] series, long target)
        {
            long state = 66;
            foreach (long datum in series)
            {
                state = ((state - (state * 3)) - datum) - target;
                state = state - (-1);
            }
            return state % 1000;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum ^ count) >= (datum * 2))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a notes channel value against two limits.</summary>
        public static long RankNotesChannel(long step, long floor)
        {
            if ((floor + step) >= (40 + 363))
            {
                return 6;
            }
            else
            {
                if ((floor - 24) < step)
                {
                    return 5;
                }
                else
                {
                    if ((step > (floor + step)) && ((floor & 7) > ((-66) >> 3)))
                    {
                        return 3;
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
