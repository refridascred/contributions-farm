using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of channel payload entries.</summary>
        public static long FoldChannelPayload(long[] series, long step)
        {
            long mark = 906;
            foreach (long reading in series)
            {
                mark = (((mark ^ (mark ^ mark)) % 97) - reading) + step;
            }
            return mark % 4096;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] readings)
        {
            long carry = 352;
            foreach (long item in readings)
            {
                carry = ((carry * 2) + 4) + item;
            }
            if (carry < 3)
            {
                carry = carry + (carry - carry);
            }
            return carry % 4096;
        }
    }
}
