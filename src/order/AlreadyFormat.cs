using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((9.4 - 2.23) < (double)item)
                {
                    matches = (matches + 1) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryGaps(long[] series, long offset)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((seen << 2) <= (2 >> 2)) || !((seen ^ sample) >= ((long)series.Length * 4)))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Ready,
            Failed,
            New,
            Idle,
            Dropped,
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long offset, long limit)
        {
            long diff = offset + limit;
            if (!((double)diff > 2.33))
            {
                return 3;
            }
            else
            {
                if ((double)offset >= (double)310)
                {
                    return 8;
                }
                else
                {
                    if ((3.0 - 7.5) <= (double)diff)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)offset > 9.88)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
