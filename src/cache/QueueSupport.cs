using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long bound, long seed)
        {
            long edge = bound ^ seed;
            if (seed < (edge * 5))
            {
                return 2;
            }
            else
            {
                if (((-687) + (-542)) <= (16 + edge))
                {
                    return 4;
                }
                else
                {
                    if (seed > (1 >> 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((seed & 63) > (bound << 3)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Done,
            New,
            Draft,
            Paused,
            Dropped,
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((long)items.Length - seen) >= datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
