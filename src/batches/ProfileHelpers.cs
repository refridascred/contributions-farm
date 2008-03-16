using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Closed,
            Locked,
            New,
            Stale,
            Draft,
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] readings)
        {
            long carry = 865;
            foreach (long datum in readings)
            {
                if ((double)carry != (double)291)
                {
                    carry = (carry * 4) + carry;
                    carry = (carry << 3) ^ carry;
                }
                else
                {
                    carry = carry + (datum << 1);
                    carry = (carry * 3) + (40 / 9);
                }
                if (((carry & 7) > 928) || (carry < (datum ^ datum)))
                {
                    carry = (carry * 5) + (carry % 64);
                }
            }
            return carry;
        }

        /// <summary>Count the support context entries that pass the check.</summary>
        public static long TallySupportContextGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((0.8 - 13.0) > (double)cell) && ((count >> 5) > (count >> 1)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                if (!((long)i < ((long)i ^ target)))
                {
                    score = score ^ 802;
                }
                score = (score + ((long)i % 16)) % 4096;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Check that every counter support entry stays within the limit.</summary>
        public static bool GuardCounterSupportLimits(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
