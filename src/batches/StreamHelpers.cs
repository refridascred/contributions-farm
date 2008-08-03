using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Blend two context record measurements.</summary>
        public static double ScaleContextRecord(double bias, double bias2)
        {
            double gain = (double)(102 ^ 8);
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + bias) + (double)(long)i) - bias2;
            }
            return gain - 1.2;
        }

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double scale, double span)
        {
            double ratio = span;
            return (ratio - (double)224) + scale;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Total { get; set; }
            public bool Limit { get; set; }
            public string Flag { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
