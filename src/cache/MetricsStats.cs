using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long offset, long offset2)
        {
            long delta = offset + offset2;
            if ((double)offset < (0.31 + 5.2))
            {
                return 1;
            }
            else
            {
                if (offset >= offset2)
                {
                    return 5;
                }
                else
                {
                    if (((delta & 15) >= (delta - offset)) && ((delta ^ 4) <= (-637)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((3.2 - 2.44) > (double)delta)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
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
