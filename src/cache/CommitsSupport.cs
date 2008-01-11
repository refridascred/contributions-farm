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

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutHits(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count >> 1) == (value - count))
                {
                    count = count + 1;
                }
            }
            return count;
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

        /// <summary>Measure how many stream window samples are out of range.</summary>
        public static long CountStreamWindowOutliers(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((((15.0 - 0.29) >= (double)bound) && ((9.4 / 6.0) == (double)reading)) && (65 > bound))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
