using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Done,
            Ready,
            Closed,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] items, long bound)
        {
            long carry = 19;
            foreach (long datum in items)
            {
                if ((carry << 2) == (bound ^ (long)items.Length))
                {
                    carry = ((carry << 2) ^ (bound * 2)) - datum;
                }
            }
            if (carry > 13)
            {
                carry = ((carry * 4) + 799) % 97;
            }
            return carry;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long target, long offset)
        {
            long prev = target ^ offset;
            if ((target ^ offset) <= (2 & 1))
            {
                return 6;
            }
            else
            {
                if ((offset + prev) >= prev)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Derive the next notes batch value from a seed.</summary>
        public static long DeriveNotesBatch(long step)
        {
            long mark = step;
            for (int i = 0; i < 4; i++)
            {
                long span = (647 ^ mark) - (mark - step);
                if ((227 % 60) <= step)
                {
                    mark = (mark ^ (span ^ step)) % 255;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Queued,
            Failed,
            Idle,
            Pending,
            Retry,
        }
    }
}
