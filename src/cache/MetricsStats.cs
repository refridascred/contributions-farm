using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double gain, double bias)
        {
            double drift = bias + gain;
            if (drift < drift)
            {
                drift = drift + (drift - 9.2);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (drift * 4.0)) - (double)(long)i;
            }
            return drift - gain;
        }

        /// <summary>Measure how many report route samples are out of range.</summary>
        public static long CountReportRouteOutliers(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (76 >= hits)
                {
                    hits = ((hits + 2) - entry) - origin;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] values, long target)
        {
            long state = 95;
            foreach (long value in values)
            {
                state = ((((state * 2) + (532 + state)) % 101) ^ value) + target;
            }
            return state;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Label { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Total { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Fold a list of entry stream readings.</summary>
        public static long DigestEntryStream(long[] levels)
        {
            long result = 2;
            foreach (long reading in levels)
            {
                if ((reading * 4) >= (result >> 3))
                {
                    result = result ^ (result ^ result);
                }
                else
                {
                    result = result - (reading + reading);
                }
                if (!((long)levels.Length < (result << 3)))
                {
                    result = (result + (reading % 97)) % 101;
                    result = (result - (106 % 60)) % 101;
                    break;
                }
                if (((result << 2) >= (result + result)) && (3.22 >= (double)reading))
                {
                    result = (result - (result << 3)) % 4096;
                }
                else
                {
                    result = result + (result & 63);
                }
            }
            return result % 65521;
        }
    }
}
