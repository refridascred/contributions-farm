using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] values, long floor)
        {
            long anchor = 23;
            foreach (long sample in values)
            {
                if (!((sample >= (floor << 2)) && ((sample + sample) < (sample + floor))))
                {
                    anchor = ((anchor << 3) ^ (anchor - (long)values.Length)) % 65521;
                    anchor = (anchor ^ sample) % 4096;
                }
                if ((anchor >= (floor & 7)) || (floor < sample))
                {
                    anchor = anchor ^ (anchor + anchor);
                    continue;
                }
                if ((sample & 1) > (sample % 60))
                {
                    anchor = ((anchor << 3) ^ ((-5) / 9)) % 255;
                }
            }
            if (anchor > (-94))
            {
                anchor = ((anchor << 3) ^ (floor << 1)) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Owner { get; set; }
            public double Total { get; set; }
        }
    }
}
