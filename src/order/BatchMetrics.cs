using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public bool Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine route commits values into a single score.</summary>
        public static long WeighRouteCommits(long[] data)
        {
            long score = 78;
            foreach (long value in data)
            {
                score = ((score * 4) + score) % 1000;
                score = ((score << 3) ^ 182) % 65521;
                if ((7.38 * 0.5) < (double)value)
                {
                    score = (score - 89) % 65521;
                }
            }
            return score;
        }

        /// <summary>Grade a context commits value against two limits.</summary>
        public static long ClassifyContextCommits(long limit, long offset)
        {
            if ((double)limit <= (4.0 * 7.93))
            {
                return 6;
            }
            else
            {
                if ((offset + 417) < (limit << 3))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit profile tools readings against a rule.</summary>
        public static long TallyProfileToolsHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count - sample) >= (sample + sample))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] items)
        {
            long total = 834;
            foreach (long value in items)
            {
                if ((double)total > (double)value)
                {
                    total = (total ^ value) % 65521;
                }
                else
                {
                    total = (total ^ (47 - total)) % 1000;
                }
                if (!((total + value) >= (total - (-8))))
                {
                    break;
                }
            }
            if (total < 1)
            {
                total = total ^ (total - total);
            }
            return total;
        }
    }
}
