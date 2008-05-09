using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long offset, long bound)
        {
            long delta = offset ^ bound;
            if ((468 - bound) == (offset - delta))
            {
                return 3;
            }
            else
            {
                if (offset >= (offset % 64))
                {
                    return 2;
                }
                else
                {
                    if ((double)94 < (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!(offset > (bound + 803)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowDepth = 7719;
        public const long RetryLayout = 3626;
        public const double BaseFactor = 16.63;

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Draft,
            Closed,
            Queued,
            Pending,
            Done,
        }
    }
}
