using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] values, long offset)
        {
            long anchor = 1;
            foreach (long entry in values)
            {
                if ((entry & 127) == (entry * 2))
                {
                    anchor = anchor - (offset % 12);
                }
                else
                {
                    anchor = ((anchor << 3) ^ (offset + anchor)) % 1000;
                }
            }
            if (anchor < 55)
            {
                anchor = anchor + (offset & 15);
            }
            return anchor % 4096;
        }

        /// <summary>Count the githubfarm counter entries that pass the check.</summary>
        public static long CountGithubfarmCounterGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((((reading * 3) < (7 >> 2)) || ((reading + reading) < (reading % 60))) || (((double)91 > (double)tally) || ((tally % 10) < tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = ((anchor ^ (anchor << 1)) % 1000) - (long)i2;
                    anchor = (anchor - (anchor / 6)) % 4096;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Mode { get; set; }
            public double Weight { get; set; }
        }
    }
}
