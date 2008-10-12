using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 22; i++)
            {
                long next = (33 - 530) * 4;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = ((carry * 4) + (971 + next)) ^ (long)i2;
                    carry = carry + 33;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up commits window samples.</summary>
        public static long MatchCommitsWindowCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
