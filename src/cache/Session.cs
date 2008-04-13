using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long seed, long floor)
        {
            if (floor > (seed + seed))
            {
                return 1;
            }
            else
            {
                if ((seed - floor) != (floor + floor))
                {
                    return 0;
                }
                else
                {
                    if ((floor % 12) < floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((floor - (-1)) <= floor) && ((seed / 8) > (floor * 3)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Draft,
            Paused,
            Pending,
            Ready,
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item / 3) < (item ^ (long)series.Length))
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }
    }
}
