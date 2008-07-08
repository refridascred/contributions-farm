using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((long)values.Length ^ cell) < (count / 7))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double weight, double offset)
        {
            double mean = (weight * 1.0) - (weight * 20.0);
            if (mean < (weight / 7.0))
            {
                mean = mean + 3.0;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (weight * 6.3)) - (double)(long)i;
            }
            return mean + (mean + offset);
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] data)
        {
            long carry = 455;
            foreach (long datum in data)
            {
                if ((9.06 / 4.0) < (double)carry)
                {
                    carry = ((carry ^ carry) % 97) ^ datum;
                }
            }
            return carry;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public long Weight { get; set; }
            public bool Ratio { get; set; }
            public double Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor << 2) ^ ((long)i ^ (-80))) % 65521;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double weight, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (weight + weight)) + (double)(long)i;
            }
            return drift - (offset / 7.0);
        }
    }
}
