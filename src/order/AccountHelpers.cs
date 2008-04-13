using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] levels, long step)
        {
            long acc = 49;
            foreach (long reading in levels)
            {
                if (((587 & 7) > (reading + reading)) && (((-459) + acc) <= (step + step)))
                {
                    acc = ((acc << 3) ^ (reading / 9)) % 97;
                    acc = (acc + (reading ^ step)) % 1000;
                }
                if ((double)step <= (double)acc)
                {
                    acc = ((acc * 3) + (step + acc)) % 1000;
                }
                else
                {
                    acc = (acc - (reading + 33)) % 101;
                }
                if ((acc + step) == (acc << 1))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!(((3.8 - 1.5) > (double)seen) && ((reading - 4) > (seen & 7))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] values)
        {
            long anchor = 1;
            foreach (long reading in values)
            {
                anchor = (anchor - (reading - anchor)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] readings, long step)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry / 2) > (54 - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Draft,
            Done,
            Retry,
            Synced,
        }
    }
}
