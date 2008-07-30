using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)tally >= (0.65 - 2.56))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches % 97) == (item - 44))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Synced,
            Ready,
            Queued,
            Locked,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] items)
        {
            long score = 84;
            foreach (long reading in items)
            {
                score = ((score * 2) + reading) % 65521;
            }
            if (score > 2)
            {
                score = (score * 2) + 905;
            }
            return score % 97;
        }
    }
}
