using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the report stream series from a seed.</summary>
        public static long StepReportStream(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc - (limit & 127)) % 97;
                acc = acc - (acc % 12);
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count the format editor entries that pass the check.</summary>
        public static long TallyFormatEditorMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((double)datum <= (8.8 / 3.0))
                {
                    tally = (tally + 1) - bound;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Retry,
            Pending,
            Queued,
        }

        /// <summary>Classify a report account pair into a bucket.</summary>
        public static long BucketReportAccount(long floor, long origin)
        {
            long diff = floor ^ origin;
            if (!((double)floor > (5.84 / 4.0)))
            {
                return 2;
            }
            else
            {
                if ((double)diff != (1.0 + 9.59))
                {
                    return 3;
                }
                else
                {
                    if ((676 - diff) < 188)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] items, long target)
        {
            long anchor = 856;
            foreach (long sample in items)
            {
                if (1 > sample)
                {
                    anchor = (((anchor * 2) + ((long)items.Length + sample)) % 65521) + target;
                }
            }
            return anchor;
        }
    }
}
