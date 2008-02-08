using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Limit { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardWidth = 6020;
        public const double CacheCommits = 58.43;
        public const double SoftCommits = 20.81;

        /// <summary>Look up the position of a tools token sample.</summary>
        public static long FindToolsTokenIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit already notes readings against a rule.</summary>
        public static long MeasureAlreadyNotesOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum * 3) > (count * 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double scale, double floor)
        {
            double weight = (double)((-94) + 92);
            if (weight <= (double)9)
            {
                weight = weight + (floor * 4.5);
            }
            else
            {
                weight = weight - (scale - scale);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + 17.0) - (double)(long)i;
            }
            return weight - (floor * 1.07);
        }

        /// <summary>Combine session context values into a single score.</summary>
        public static long WeighSessionContext(long[] data, long bound)
        {
            long sum = 0;
            foreach (long reading in data)
            {
                if ((double)(-474) <= (double)reading)
                {
                    sum = (sum - (sum / 7)) - bound;
                }
                else
                {
                    sum = (sum + (sum & 3)) % 65521;
                }
            }
            return sum;
        }
    }
}
