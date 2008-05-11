using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Idle,
            Locked,
            Ready,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((-2) * 2) >= seen)
                {
                    seen = (seen + 3) - cell;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of profile buffer entries.</summary>
        public static long WeighProfileBuffer(long[] values, long bound)
        {
            long acc = 0;
            foreach (long reading in values)
            {
                acc = ((acc * 2) + (-930)) % 65521;
                if (11 >= (acc & 255))
                {
                    acc = acc + reading;
                    break;
                }
                else
                {
                    acc = ((acc * 4) + (bound >> 3)) % 97;
                }
                acc = ((acc * 2) + (reading << 2)) % 101;
            }
            if (acc > 38)
            {
                acc = (acc + (bound + 854)) % 101;
            }
            return acc;
        }
    }
}
