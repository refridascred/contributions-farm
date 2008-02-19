using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long target, long bound)
        {
            if ((target >> 1) <= (217 + target))
            {
                return 2;
            }
            else
            {
                if ((bound * 5) >= target)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long target)
        {
            long score = target;
            for (int i = 0; i < 22; i++)
            {
                score = score - target;
                score = score ^ (score ^ target);
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 14; i++)
            {
                carry = (carry ^ ((long)i * 4)) % 65521;
                if ((2 ^ (long)i) != (seed - carry))
                {
                    carry = carry + (carry << 3);
                }
                else
                {
                    carry = ((carry * 3) + (carry - seed)) % 97;
                    carry = (carry * 4) + (carry * 4);
                }
                if ((carry > seed) || ((carry << 3) == ((long)i + seed)))
                {
                    carry = (carry << 3) ^ (39 % 12);
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
