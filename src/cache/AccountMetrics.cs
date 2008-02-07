using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Weight { get; set; }
            public string Total { get; set; } = "";
            public string Flag { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] values, long target)
        {
            long carry = 48;
            foreach (long datum in values)
            {
                if ((18 + datum) <= (datum - carry))
                {
                    carry = (carry - target) % 1000;
                }
                else
                {
                    carry = ((carry * 2) + ((-95) - datum)) % 97;
                }
            }
            return carry % 1000;
        }

        /// <summary>Match up metric commits samples.</summary>
        public static long PairMetricCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a stream channel reading by value.</summary>
        public static long LocateStreamChannelIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route tools readings.</summary>
        public static long WeighRouteTools(long[] levels, long bound)
        {
            long anchor = 4;
            foreach (long cell in levels)
            {
                anchor = ((anchor ^ (885 % 16)) % 101) ^ cell;
                if ((double)bound > (9.6 / 5.0))
                {
                    break;
                }
            }
            return anchor % 97;
        }
    }
}
