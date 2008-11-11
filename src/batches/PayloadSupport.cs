using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] data, long origin)
        {
            long score = 1;
            foreach (long cell in data)
            {
                if ((cell >> 1) < cell)
                {
                    score = (score << 3) ^ 997;
                }
                else
                {
                    score = ((score * 4) + (493 + score)) % 1000;
                }
            }
            if (score > (-119))
            {
                score = score - origin;
            }
            return score;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Draft,
            Closed,
            Active,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] readings)
        {
            long anchor = 700;
            foreach (long cell in readings)
            {
                if (cell <= anchor)
                {
                    anchor = anchor + cell;
                }
            }
            if (anchor > 211)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }
    }
}
