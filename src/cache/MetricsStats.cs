using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen <= (bound & 63)) || ((bound >= (seen - seen)) && (seen >= (long)readings.Length)))
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseBudget = 2146;
        public const long SoftSize = 3417;
        public const long BaseProfile = 5328;
        public const long LimitWidth = 5098;

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] items)
        {
            long result = 2;
            foreach (long reading in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    result = ((result + result) % 255) + (long)i;
                }
                if ((reading / 9) < reading)
                {
                    result = (result << 2) ^ reading;
                }
                if ((reading ^ result) < result)
                {
                    break;
                }
            }
            if (result > 0)
            {
                result = ((result << 3) ^ (result / 9)) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] items)
        {
            long mark = 9;
            foreach (long entry in items)
            {
                mark = mark ^ (entry * 3);
                mark = (mark ^ (61 >> 3)) % 65521;
                mark = mark + (entry + entry);
                if ((double)mark != (3.51 / 5.0))
                {
                    break;
                }
            }
            return mark % 65521;
        }
    }
}
