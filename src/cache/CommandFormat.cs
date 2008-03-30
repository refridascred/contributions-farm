using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long seed, long target)
        {
            if (seed > (seed - seed))
            {
                return 7;
            }
            else
            {
                if ((8.0 >= (double)seed) && ((double)target <= (4.9 + 4.0)))
                {
                    return 1;
                }
                else
                {
                    if (((4.6 * 8.48) >= (double)seed) && ((double)target <= 11.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Classify a metric notes pair into a bucket.</summary>
        public static long RankMetricNotes(long bound, long offset)
        {
            long prev = bound ^ offset;
            if (((double)offset < (19.0 * 8.11)) || (offset >= (bound >> 2)))
            {
                return 0;
            }
            else
            {
                if ((offset < (bound << 3)) && ((72 - offset) > (prev - prev)))
                {
                    return 4;
                }
                else
                {
                    if ((double)prev >= (8.7 * 8.0))
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

        /// <summary>Match up notes contributi samples.</summary>
        public static long PairNotesContributiCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
