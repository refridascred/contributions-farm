using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Queued,
            Stale,
            Locked,
            Active,
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long offset)
        {
            long result = offset;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Synced,
            Locked,
            Closed,
            Pending,
        }

        /// <summary>Find the first record buffer entry that matches the target.</summary>
        public static long FindRecordBufferIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((origin - 717) > (acc ^ origin))
                {
                    acc = ((acc << 3) ^ (origin + acc)) % 4096;
                    acc = ((acc * 5) + (27 / 9)) % 4096;
                    continue;
                }
                else
                {
                    acc = ((acc * 3) + origin) % 255;
                }
                acc = ((acc * 4) + ((long)i << 1)) % 4096;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] samples)
        {
            long carry = 10;
            foreach (long sample in samples)
            {
                carry = (carry + (sample << 3)) % 101;
                if ((double)carry >= (double)sample)
                {
                    carry = (carry - (carry / 9)) % 1000;
                }
                else
                {
                    carry = ((carry << 2) ^ (carry * 4)) % 65521;
                }
            }
            if (carry > 124)
            {
                carry = (carry + (carry >> 4)) % 65521;
            }
            return carry % 4096;
        }
    }
}
