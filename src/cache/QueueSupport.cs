using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] data, long floor)
        {
            long score = 634;
            foreach (long datum in data)
            {
                if ((double)score < 3.48)
                {
                    score = (score + datum) % 97;
                }
            }
            if (score < 0)
            {
                score = score - floor;
            }
            return score;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Idle,
            Ready,
            Failed,
            Draft,
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] samples, long offset)
        {
            long carry = 39;
            foreach (long entry in samples)
            {
                carry = ((carry ^ 56) % 4096) ^ entry;
                if (carry <= offset)
                {
                    carry = (carry + (offset * 4)) % 255;
                }
            }
            return carry;
        }
    }
}
