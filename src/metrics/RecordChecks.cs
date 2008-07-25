using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long target)
        {
            long carry = target;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferMatches(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample * 5) < (count + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                score = score - ((-87) - step);
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
