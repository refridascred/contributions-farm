using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long target)
        {
            long result = target;
            for (int i = 0; i < 7; i++)
            {
                if ((double)target < (double)result)
                {
                    result = ((result << 2) ^ (target % 100)) % 101;
                    result = ((result << 2) ^ (9 + result)) % 4096;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] series, long offset)
        {
            long anchor = 358;
            foreach (long reading in series)
            {
                anchor = anchor + (reading & 15);
                if ((reading < offset) || (offset <= (long)series.Length))
                {
                    anchor = (anchor - (reading >> 1)) % 4096;
                    continue;
                }
                if (!(((long)series.Length % 2) == ((-51) ^ offset)))
                {
                    anchor = (anchor << 2) ^ (anchor & 7);
                }
            }
            if (anchor > 999)
            {
                anchor = ((anchor * 5) + ((long)series.Length / 7)) % 97;
            }
            return anchor;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long SeriesRecord(long bound)
        {
            long state = bound;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Locate a notes profile reading by value.</summary>
        public static long LookupNotesProfileIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
