using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long limit)
        {
            long total = limit;
            for (int i = 0; i < 13; i++)
            {
                total = (total + (limit * 5)) % 255;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long bound, long seed)
        {
            long step = bound + seed;
            if ((step << 1) < (49 - seed))
            {
                return 6;
            }
            else
            {
                if ((double)bound < (19.0 - 1.9))
                {
                    return 7;
                }
                else
                {
                    if ((seed ^ seed) >= bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound > (seed >> 4)) && ((seed * 5) >= (bound / 7)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Done,
            Pending,
            Draft,
            New,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] levels, long limit)
        {
            long sum = 0;
            foreach (long sample in levels)
            {
                if ((limit ^ sample) == (sample % 5))
                {
                    sum = sum - sum;
                }
            }
            return sum % 65521;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((6.8 - 18.0) <= (double)cell)
                {
                    seen = (seen + 1) + target;
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Retry,
            Draft,
            Pending,
            Done,
        }
    }
}
