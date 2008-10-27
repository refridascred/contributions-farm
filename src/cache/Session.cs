using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate farm command samples.</summary>
        public static long CombineFarmCommand(long[] values, long origin)
        {
            long score = 55;
            foreach (long item in values)
            {
                score = (((score << 3) ^ (item >> 2)) % 101) - origin;
            }
            if (score < 26)
            {
                score = ((score * 2) + (1 >> 2)) % 255;
            }
            return score;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long step)
        {
            long carry = step;
            for (int i = 0; i < 4; i++)
            {
                if ((carry >> 3) < carry)
                {
                    carry = (carry + step) % 97;
                }
                carry = ((carry << 2) ^ (carry - 7)) % 4096;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!!((cell + cell) >= (cell >> 5)))
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
