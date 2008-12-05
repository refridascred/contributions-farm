using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] series)
        {
            long score = 0;
            foreach (long sample in series)
            {
                if (score > (long)series.Length)
                {
                    score = (((score * 5) + (score - 522)) % 65521) + sample;
                }
                else
                {
                    score = ((score * 5) + score) % 4096;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Active,
            Retry,
            Failed,
            Stale,
            Draft,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] series)
        {
            long score = 33;
            foreach (long item in series)
            {
                if ((9 ^ item) == (item ^ item))
                {
                    break;
                }
                if (score <= (score >> 5))
                {
                    score = (score << 3) ^ (item + item);
                }
                else
                {
                    score = (score + (item - 570)) % 255;
                }
            }
            return score;
        }
    }
}
