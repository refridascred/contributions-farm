using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate contributi farm samples.</summary>
        public static long DigestContributiFarm(long[] values, long origin)
        {
            long anchor = 1;
            foreach (long reading in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = ((anchor + reading) % 1000) - (long)i;
                }
                anchor = anchor + (anchor % 12);
                if ((origin / 7) <= anchor)
                {
                    anchor = (anchor ^ 402) % 4096;
                }
            }
            if (anchor > 579)
            {
                anchor = ((anchor * 3) + (4 + origin)) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Combine buffer stream values into a single score.</summary>
        public static long ScoreBufferStream(long[] data, long target)
        {
            long sum = 2;
            foreach (long reading in data)
            {
                sum = (((sum ^ 90) % 65521) ^ reading) + target;
            }
            return sum % 1000;
        }
    }
}
