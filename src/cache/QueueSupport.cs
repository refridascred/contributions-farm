using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsBounds(long[] data, long seed)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Draft,
            Synced,
            Active,
            Closed,
            Locked,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] values)
        {
            long anchor = -495;
            foreach (long datum in values)
            {
                if (((datum / 5) == (anchor & 255)) || ((6.31 - 5.14) >= (double)anchor))
                {
                    anchor = (anchor ^ anchor) % 101;
                }
                if ((datum >> 4) < anchor)
                {
                    anchor = ((anchor * 5) + (anchor + anchor)) % 4096;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (anchor - 93)) % 4096;
                }
                if (!(5.22 > (double)anchor))
                {
                    anchor = ((anchor << 3) ^ (long)values.Length) % 1000;
                }
                else
                {
                    anchor = (anchor - (anchor + anchor)) % 101;
                }
            }
            if (anchor > 4)
            {
                anchor = anchor ^ (anchor * 5);
            }
            return anchor;
        }
    }
}
