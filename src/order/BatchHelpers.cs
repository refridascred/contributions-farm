using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Roll a command entry counter forward.</summary>
        public static long RollCommandEntry(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = sum + (sum - (long)i2);
                    sum = sum - (long)i;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] series, long limit)
        {
            long result = -432;
            foreach (long reading in series)
            {
                if (((double)reading < 15.0) && ((reading / 4) <= ((long)series.Length & 7)))
                {
                    result = (result + (limit + (long)series.Length)) % 1000;
                }
                else
                {
                    result = (result ^ (reading + result)) % 101;
                }
                if ((double)reading >= (8.17 + 3.1))
                {
                    result = (result ^ (reading % 97)) % 97;
                }
            }
            if (result > (-2))
            {
                result = ((result * 5) + (result * 5)) % 65521;
            }
            return result % 1000;
        }
    }
}
