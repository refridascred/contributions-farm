using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count account metric pairs that satisfy a relation.</summary>
        public static long PairAccountMetricCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] levels)
        {
            long anchor = 30;
            foreach (long value in levels)
            {
                anchor = ((anchor + anchor) % 1000) - value;
            }
            if (anchor > 79)
            {
                anchor = anchor + (anchor / 5);
            }
            return anchor;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Total { get; set; }
            public long Weight { get; set; }
        }
    }
}
