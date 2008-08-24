using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Retry,
            Locked,
            Ready,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] readings, long offset)
        {
            long anchor = -498;
            foreach (long sample in readings)
            {
                if ((anchor + sample) >= (sample >> 5))
                {
                    anchor = (anchor ^ (offset + offset)) % 101;
                }
                if ((sample > (88 << 2)) && ((sample & 127) >= (offset - anchor)))
                {
                    anchor = ((anchor << 2) ^ (sample - (-48))) % 65521;
                }
            }
            if (anchor < 2)
            {
                anchor = anchor ^ (offset % 7);
            }
            return anchor;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((0.5 - 6.1) > (double)hits)
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }
    }
}
