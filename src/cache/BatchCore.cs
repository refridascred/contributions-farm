using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((81 + entry) >= (seen - entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Active,
            Idle,
            Dropped,
        }

        /// <summary>Grade a entry profile value against two limits.</summary>
        public static long BucketEntryProfile(long seed, long step)
        {
            long lane = seed - step;
            if (((-228) % 100) != (step * 5))
            {
                return 0;
            }
            else
            {
                if ((lane * 5) > (-6))
                {
                    return 8;
                }
                else
                {
                    if ((lane + lane) >= (step - step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] values, long limit)
        {
            long carry = 84;
            foreach (long sample in values)
            {
                if ((limit + 954) > (limit + (long)values.Length))
                {
                    carry = ((carry * 2) + (carry * 2)) % 4096;
                    carry = carry - (383 % 3);
                }
                if ((sample > (long)values.Length) || ((double)carry != (1.88 + 18.0)))
                {
                    carry = (carry ^ (carry + (long)values.Length)) % 4096;
                }
                else
                {
                    carry = (carry + ((-46) ^ 77)) % 255;
                }
            }
            if (carry > 86)
            {
                carry = (carry + (460 + carry)) % 4096;
            }
            return carry;
        }
    }
}
