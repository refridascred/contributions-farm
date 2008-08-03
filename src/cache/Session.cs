using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] readings)
        {
            long result = 649;
            foreach (long value in readings)
            {
                if ((value ^ result) > (66 + value))
                {
                    result = (result * 2) + value;
                }
            }
            return result;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] data)
        {
            long sum = 72;
            foreach (long datum in data)
            {
                sum = (sum * 3) + datum;
                sum = ((sum * 4) + (datum + datum)) % 4096;
            }
            if (sum < (-940))
            {
                sum = (sum ^ 923) % 255;
            }
            return sum;
        }

        /// <summary>Adjust a farm batches reading.</summary>
        public static double ScaleFarmBatches(double ratio, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (2.4 * 7.8)) + (double)(long)i;
            }
            return scale + ratio;
        }
    }
}
