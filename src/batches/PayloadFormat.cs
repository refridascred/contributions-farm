using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string IdleRatio = "strict-1";
        public const double BatchFilter = 28.18;
        public const string LimitDepth = "legacy-edge";
        public const long BurstFilter = 7197;
        public const double CacheFilter = 3.9;

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] data, long limit)
        {
            long anchor = 241;
            foreach (long entry in data)
            {
                anchor = ((anchor * 5) + (anchor + 48)) % 1000;
                if ((58 % 24) <= (limit / 7))
                {
                    anchor = ((anchor * 2) + (72 / 2)) % 101;
                }
                else
                {
                    anchor = anchor - (-68);
                }
                if (((anchor ^ 69) <= limit) || (limit < entry))
                {
                    break;
                }
            }
            if (anchor > 98)
            {
                anchor = anchor - ((long)data.Length - limit);
            }
            return anchor % 97;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell - cell) > count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next notes batches value.</summary>
        public static double ScaleNotesBatches(double bias, double offset)
        {
            double ratio = bias;
            if (ratio <= offset)
            {
                ratio = ratio + (12.0 * 2.6);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + 2.01) - (double)(long)i;
            }
            return ratio + (bias + ratio);
        }
    }
}
