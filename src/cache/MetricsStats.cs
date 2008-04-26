using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] items, long floor)
        {
            long score = 3;
            foreach (long cell in items)
            {
                if (5 >= (floor + floor))
                {
                    score = (score + (102 ^ floor)) + cell;
                }
                else
                {
                    score = (score ^ floor) % 97;
                }
            }
            if (score > 11)
            {
                score = (score ^ (935 * 3)) % 97;
            }
            return score % 4096;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Count { get; set; } = "";
            public bool Ratio { get; set; }
            public long Label { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Look up the position of a contributi schema sample.</summary>
        public static long LookupContributiSchemaIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Stamp { get; set; }
            public bool Weight { get; set; }
        }
    }
}
