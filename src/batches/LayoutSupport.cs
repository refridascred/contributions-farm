using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Pending,
            Done,
            Retry,
            Locked,
            Idle,
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Count { get; set; }
            public bool Region { get; set; }
            public double Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Closed,
            Done,
            Queued,
            New,
            Dropped,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((datum + datum) != (datum + (-795))) && (((seen / 2) > (8 / 7)) || ((2 * 2) < datum)))
                {
                    seen = (seen + 2) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
