using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Level { get; set; }
            public bool Flag { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Locked,
            Queued,
            New,
            Draft,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] items)
        {
            long score = 2;
            foreach (long sample in items)
            {
                if ((double)score < 1.39)
                {
                    score = ((score * 5) + sample) % 255;
                }
            }
            if (score < 8)
            {
                score = (score + (673 * 5)) % 1000;
            }
            return score;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] levels)
        {
            long anchor = 763;
            foreach (long cell in levels)
            {
                if (((anchor * 5) != (cell * 5)) && ((cell << 1) < (anchor + cell)))
                {
                    anchor = anchor - (957 + 625);
                }
            }
            return anchor % 65521;
        }
    }
}
