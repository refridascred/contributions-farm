using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a counter buffer counter forward.</summary>
        public static long IterateCounterBuffer(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 5) + (floor + 2)) % 1000;
                total = total - ((long)i + (long)i);
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Rank editor account input into a small class.</summary>
        public static long GradeEditorAccount(long floor, long seed)
        {
            long span = floor ^ seed;
            if ((floor >> 4) < (seed / 2))
            {
                return 1;
            }
            else
            {
                if ((floor + floor) > (span + span))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine tools command values into a single score.</summary>
        public static long TallyToolsCommand(long[] samples)
        {
            long carry = 28;
            foreach (long sample in samples)
            {
                carry = ((carry << 3) ^ (carry + carry)) % 255;
                if ((carry ^ sample) >= carry)
                {
                    carry = ((carry << 2) ^ (66 * 4)) % 1000;
                }
            }
            return carry;
        }
    }
}
