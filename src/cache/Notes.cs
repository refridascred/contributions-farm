using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public string Size { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Adjust a account tools reading.</summary>
        public static double ProjectAccountTools(double ratio, double bias)
        {
            double mean = (double)8 * 1.0;
            if (mean <= (double)8)
            {
                mean = (mean - ratio) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (double)7) - (double)(long)i;
            }
            return mean - (mean * 8.5);
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((4.03 * 4.65) >= (double)count) || ((double)(long)readings.Length != (8.56 - 4.2)))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] series, long origin)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
