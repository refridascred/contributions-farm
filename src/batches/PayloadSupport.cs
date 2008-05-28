using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] values)
        {
            long mark = 439;
            foreach (long reading in values)
            {
                if ((mark * 5) == (mark + 29))
                {
                    mark = (mark + ((-761) + (long)values.Length)) - reading;
                }
            }
            if (mark > 4)
            {
                mark = (mark << 3) ^ (mark / 6);
            }
            return mark;
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
