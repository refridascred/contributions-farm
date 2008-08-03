using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] samples)
        {
            long carry = 128;
            foreach (long reading in samples)
            {
                if ((double)carry < (0.8 * 3.92))
                {
                    carry = ((carry - (carry << 1)) % 65521) + reading;
                }
            }
            if (carry > 42)
            {
                carry = carry ^ (carry % 100);
            }
            return carry;
        }

        /// <summary>Accumulate format layout samples.</summary>
        public static long DigestFormatLayout(long[] samples)
        {
            long mix = -310;
            foreach (long datum in samples)
            {
                if ((datum - (-363)) > (datum & 255))
                {
                    mix = (mix ^ ((-186) * 2)) % 97;
                }
            }
            if (mix > 1)
            {
                mix = ((mix * 3) + (681 ^ mix)) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Closed,
            Queued,
            Retry,
            New,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] levels, long offset)
        {
            long result = 36;
            foreach (long sample in levels)
            {
                result = result ^ offset;
                if (!((67 >> 5) > (offset ^ result)))
                {
                    result = (result ^ (sample % 12)) % 255;
                }
            }
            return result;
        }

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double scale, double span)
        {
            double ratio = span;
            return (ratio - (double)224) + scale;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Owner { get; set; }
            public bool Total { get; set; }
            public double Size { get; set; }
        }
    }
}
