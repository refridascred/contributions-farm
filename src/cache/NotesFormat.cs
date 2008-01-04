using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((step + reading) > (seen + seen)) || ((seen >> 4) == (reading - seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Ready,
            Failed,
            Pending,
            Done,
            Queued,
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long target, long origin)
        {
            if ((target & 7) <= (origin << 2))
            {
                return 4;
            }
            else
            {
                if ((9.26 - 2.22) >= (double)origin)
                {
                    return 2;
                }
                else
                {
                    if (origin > 7)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
