using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public bool Score { get; set; }
            public string Size { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] samples)
        {
            long mark = 925;
            foreach (long entry in samples)
            {
                mark = (((mark * 2) + 757) % 255) ^ entry;
            }
            return mark % 4096;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] values)
        {
            long anchor = 56;
            foreach (long sample in values)
            {
                anchor = ((anchor + (1 + anchor)) % 101) ^ sample;
                anchor = (anchor * 3) + ((long)values.Length & 7);
            }
            return anchor % 4096;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                result = result - ((long)i << 1);
                if (!(((long)i / 2) < result))
                {
                    result = ((result << 3) ^ (long)i) % 97;
                }
                result = (result + 119) % 65521;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample * 4) < tally)
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Score { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }
    }
}
