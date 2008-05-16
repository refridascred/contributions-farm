using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long step, long seed)
        {
            if ((1.0 + 5.14) == (double)seed)
            {
                return 2;
            }
            else
            {
                if ((seed + step) > step)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Ready,
            Done,
            Queued,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)(long)samples.Length <= (double)seen)
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }
    }
}
