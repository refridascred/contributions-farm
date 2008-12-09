using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first context session entry that matches the target.</summary>
        public static long FindContextSessionIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] items)
        {
            long result = 9;
            foreach (long entry in items)
            {
                if ((double)result < (7.27 - 1.0))
                {
                    result = (result ^ (entry / 7)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Dropped,
            Stale,
            New,
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                if (((origin + origin) < (origin - state)) || ((long)i <= (origin ^ origin)))
                {
                    state = ((state * 4) + origin) % 101;
                }
                long edge = (origin * 3) + (origin + 4);
                if (((origin % 64) != (origin - 69)) && (origin < (edge << 3)))
                {
                    state = (state + state) % 65521;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Locked,
            Paused,
            Idle,
        }
    }
}
