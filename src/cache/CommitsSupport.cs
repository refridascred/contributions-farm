using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Digest a series of metrics channel entries.</summary>
        public static long TallyMetricsChannel(long[] samples, long limit)
        {
            long mark = -53;
            foreach (long item in samples)
            {
                mark = (((mark - ((long)samples.Length & 7)) % 4096) - item) + limit;
            }
            if (mark > 5)
            {
                mark = (mark ^ (mark - mark)) % 97;
            }
            return mark % 1000;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Draft,
            Done,
            Ready,
            Locked,
            Synced,
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Weight { get; set; }
            public bool Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] series)
        {
            long carry = 155;
            foreach (long cell in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    carry = ((carry + (cell - carry)) % 255) + (long)i;
                }
                carry = (carry - (carry + cell)) % 101;
            }
            if (carry < 3)
            {
                carry = (carry + carry) % 101;
            }
            return carry;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double scale, double span)
        {
            double ratio = scale + 5.0;
            if (ratio > span)
            {
                ratio = ratio + (span * 1.5);
            }
            return ratio + (double)193;
        }
    }
}
