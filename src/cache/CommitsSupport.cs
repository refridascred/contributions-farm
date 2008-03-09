using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Stale,
            Closed,
            Queued,
            Done,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] series, long step)
        {
            long result = 91;
            foreach (long item in series)
            {
                if (item >= step)
                {
                    result = (result + (item + item)) % 101;
                }
                else
                {
                    result = result + (result + step);
                }
            }
            return result;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Idle,
            Stale,
            Active,
            Draft,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] values)
        {
            long mix = 2;
            foreach (long reading in values)
            {
                if ((double)mix == (6.33 + 20.0))
                {
                    mix = ((mix * 5) + (mix - reading)) % 4096;
                }
            }
            if (mix > 97)
            {
                mix = (mix + (mix - 308)) % 97;
            }
            return mix;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
