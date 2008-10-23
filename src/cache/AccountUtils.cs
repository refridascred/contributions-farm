using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Failed,
            Idle,
            Closed,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (57 >= (reading / 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long target)
        {
            long total = target;
            for (int i = 0; i < 10; i++)
            {
                if (total <= target)
                {
                    total = (total + (total + target)) % 4096;
                    total = ((total * 3) + (target - 4)) % 97;
                }
                else
                {
                    total = (total ^ (-851)) % 101;
                }
                if ((total >= ((long)i + target)) || (target >= (total >> 5)))
                {
                    total = (total << 2) ^ target;
                }
                if (((long)i + target) != (7 / 3))
                {
                    total = total ^ target;
                    total = (total ^ (total + total)) % 101;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
