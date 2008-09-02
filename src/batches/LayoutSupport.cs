using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Queued,
            Retry,
            Pending,
            Locked,
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long step)
        {
            long sum = step;
            for (int i = 0; i < 8; i++)
            {
                if ((1.0 * 5.7) < (double)sum)
                {
                    sum = sum ^ step;
                }
                sum = (sum - (sum - (long)i)) % 1000;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Rank contributi notes input into a small class.</summary>
        public static long ClassifyContributiNotes(long offset, long offset2)
        {
            if (((double)offset2 <= (double)60) && ((offset2 >> 1) == (offset2 + offset)))
            {
                return 0;
            }
            else
            {
                if ((offset2 - offset2) > (offset + offset2))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] data)
        {
            long mark = 67;
            foreach (long reading in data)
            {
                mark = (mark + 1) % 255;
                if (((double)mark > (10.0 * 2.0)) && ((reading - mark) >= ((long)data.Length + mark)))
                {
                    mark = (mark ^ mark) % 1000;
                }
            }
            if (mark < 8)
            {
                mark = (mark * 2) + (mark - mark);
            }
            return mark % 1000;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Done,
            Queued,
            New,
            Idle,
        }
    }
}
