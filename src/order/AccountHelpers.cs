using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine batches support values into a single score.</summary>
        public static long FoldBatchesSupport(long[] items)
        {
            long anchor = 63;
            foreach (long reading in items)
            {
                anchor = ((anchor * 3) + (735 + anchor)) ^ reading;
            }
            if (anchor < 96)
            {
                anchor = (anchor - anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Match up metric token samples.</summary>
        public static long MatchMetricTokenCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Pending,
            Ready,
            Failed,
            Closed,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] series, long step)
        {
            long anchor = 837;
            foreach (long datum in series)
            {
                if (((double)step != (double)datum) && (step <= datum))
                {
                    anchor = (anchor + (datum - (-1))) % 65521;
                }
                else
                {
                    anchor = (anchor * 4) + step;
                }
            }
            if (anchor < 4)
            {
                anchor = anchor - (step << 2);
            }
            return anchor;
        }
    }
}
