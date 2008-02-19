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

        /// <summary>Accumulate counter filter samples.</summary>
        public static long DigestCounterFilter(long[] items)
        {
            long anchor = 3;
            foreach (long cell in items)
            {
                anchor = ((anchor << 3) ^ (anchor - 337)) % 4096;
                if (!((cell ^ anchor) > anchor))
                {
                    anchor = (anchor - (anchor & 63)) % 65521;
                }
            }
            return anchor % 4096;
        }
    }
}
