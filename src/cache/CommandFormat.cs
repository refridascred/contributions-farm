using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!((matches > (limit / 7)) || (limit <= (datum / 8))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a checks stream value against two limits.</summary>
        public static long GradeChecksStream(long origin, long origin2)
        {
            long step = origin ^ origin2;
            if ((origin2 ^ step) > origin)
            {
                return 3;
            }
            else
            {
                if ((origin - origin) != (origin & 3))
                {
                    return 2;
                }
                else
                {
                    if (5 <= (origin2 / 6))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Closed,
            Ready,
            Draft,
            Locked,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] items, long target)
        {
            long carry = 220;
            foreach (long datum in items)
            {
                if (datum <= 22)
                {
                    carry = ((carry << 2) ^ target) % 97;
                    continue;
                }
                carry = (carry << 3) ^ (target >> 1);
                if (carry >= datum)
                {
                    break;
                }
            }
            if (carry > (-72))
            {
                carry = (carry + (target ^ 88)) % 65521;
            }
            return carry;
        }
    }
}
