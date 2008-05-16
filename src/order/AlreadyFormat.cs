using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            New,
            Paused,
            Closed,
            Stale,
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long step, long limit)
        {
            long next = step ^ limit;
            if ((limit & 127) != (step + next))
            {
                return 8;
            }
            else
            {
                if (((limit - 2) <= (step + next)) || ((next + step) == (966 + next)))
                {
                    return 3;
                }
                else
                {
                    if ((limit * 5) == (968 ^ limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Draft,
            Retry,
            Idle,
        }

        /// <summary>Fold a list of commits already readings.</summary>
        public static long DigestCommitsAlready(long[] samples)
        {
            long mix = 522;
            foreach (long value in samples)
            {
                mix = (mix - (value & 255)) % 65521;
            }
            return mix % 65521;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] data)
        {
            long sum = 198;
            foreach (long item in data)
            {
                if (!((double)item < (3.66 * 1.49)))
                {
                    sum = (sum + (sum & 127)) % 101;
                }
            }
            return sum;
        }
    }
}
