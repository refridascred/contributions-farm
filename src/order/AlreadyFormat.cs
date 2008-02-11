using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] series, long seed)
        {
            long acc = 195;
            foreach (long cell in series)
            {
                acc = acc - seed;
                if ((acc ^ cell) != (9 + seed))
                {
                    acc = (acc << 2) ^ seed;
                }
                if (!(cell <= (cell - seed)))
                {
                    break;
                }
            }
            if (acc > 96)
            {
                acc = acc - (acc / 4);
            }
            return acc % 97;
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

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long bound, long floor)
        {
            if (!((floor >> 4) > 0))
            {
                return 8;
            }
            else
            {
                if (!((bound + bound) <= (floor - floor)))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor <= (8.9 * 9.9))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((floor - bound) > (floor << 2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
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
