using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Ready,
            Paused,
            Failed,
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Locked,
            Active,
            Pending,
            Failed,
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry << 3) ^ (carry - offset);
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Digest a series of support buffer entries.</summary>
        public static long WeighSupportBuffer(long[] readings)
        {
            long mix = 5;
            foreach (long reading in readings)
            {
                if ((double)reading != (9.04 - 5.44))
                {
                    mix = ((mix << 3) ^ (mix ^ reading)) % 65521;
                }
            }
            return mix % 97;
        }
    }
}
