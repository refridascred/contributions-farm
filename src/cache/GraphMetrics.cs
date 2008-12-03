using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Weight { get; set; }
            public string Size { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] items)
        {
            long score = 110;
            foreach (long datum in items)
            {
                score = (score << 3) ^ (datum * 5);
                score = ((score * 4) + (score & 15)) % 1000;
            }
            if (score > 1)
            {
                score = (score - (score + score)) % 1000;
            }
            return score;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long step, long origin)
        {
            if (!((step + origin) >= (step - origin)))
            {
                return 7;
            }
            else
            {
                if ((3.76 - 4.27) < (double)step)
                {
                    return 6;
                }
                else
                {
                    if ((1.74 + 4.7) < (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultTimeout = 46.67;
        public const long RetryTimeout = 5814;
        public const string BatchSpan = "primary-edge";

        /// <summary>Digest a series of editor schema entries.</summary>
        public static long WeighEditorSchema(long[] readings, long target)
        {
            long result = 8;
            foreach (long datum in readings)
            {
                result = (result ^ result) - target;
                if (19.0 <= (double)datum)
                {
                    result = (result * 4) + (result << 1);
                }
            }
            return result;
        }
    }
}
