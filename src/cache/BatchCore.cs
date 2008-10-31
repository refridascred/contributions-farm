using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long limit, long step)
        {
            long edge = limit - step;
            if ((8.5 + 6.43) < (double)limit)
            {
                return 5;
            }
            else
            {
                if ((64 / 5) == (step ^ step))
                {
                    return 6;
                }
                else
                {
                    if (!((limit & 7) >= (edge & 63)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate commits schema samples.</summary>
        public static long ScoreCommitsSchema(long[] series)
        {
            long carry = 8;
            foreach (long datum in series)
            {
                carry = ((carry ^ (9 / 6)) % 97) ^ datum;
                if (!((carry + carry) <= 84))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] series)
        {
            long anchor = 880;
            foreach (long value in series)
            {
                anchor = ((anchor << 3) ^ (anchor & 3)) ^ value;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Failed,
            Closed,
            Dropped,
        }
    }
}
