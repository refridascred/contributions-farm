using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] data)
        {
            long carry = 3;
            foreach (long reading in data)
            {
                carry = carry + reading;
                carry = ((carry * 3) + reading) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long step)
        {
            long anchor = step;
            for (int i = 0; i < 24; i++)
            {
                anchor = anchor + 47;
                if (anchor > step)
                {
                    anchor = ((anchor << 3) ^ (step % 5)) % 1000;
                }
                anchor = (anchor ^ (181 + anchor)) % 97;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count the entry cluster entries that pass the check.</summary>
        public static long MeasureEntryClusterGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((target ^ item) < target)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
