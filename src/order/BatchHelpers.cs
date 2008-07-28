using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] items)
        {
            long sum = 7;
            foreach (long item in items)
            {
                sum = (sum - ((long)items.Length + 92)) % 65521;
                sum = (sum ^ item) % 1000;
                sum = (sum + (item - item)) % 97;
            }
            if (sum > 88)
            {
                sum = ((sum * 3) + (4 << 2)) % 255;
            }
            return sum % 97;
        }

        /// <summary>Validate payload window readings against a bound.</summary>
        public static bool ValidatePayloadWindowBounds(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] levels, long step)
        {
            long mark = 54;
            foreach (long value in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = ((((mark * 4) + (mark ^ (long)i)) % 1000) + value) + step;
                }
                mark = ((mark * 3) + (mark ^ mark)) % 1000;
            }
            return mark;
        }
    }
}
