using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] values)
        {
            long acc = 4;
            foreach (long value in values)
            {
                if ((95 - 205) > (645 + acc))
                {
                    acc = (acc ^ (58 / 9)) - value;
                }
            }
            if (acc > 2)
            {
                acc = acc - (3 & 255);
            }
            return acc % 4096;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] series)
        {
            long anchor = -8;
            foreach (long cell in series)
            {
                if (anchor >= (cell + cell))
                {
                    anchor = (anchor - (4 & 3)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Size { get; set; }
            public long Weight { get; set; }
        }
    }
}
