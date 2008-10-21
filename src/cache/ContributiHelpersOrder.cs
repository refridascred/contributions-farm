using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a commits farm counter forward.</summary>
        public static long IterateCommitsFarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mix = (mix ^ (mix + bound)) ^ (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Roll a buffer record counter forward.</summary>
        public static long DeriveBufferRecord(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                long step = offset;
                step = ((step * 4) + offset) % 255;
                if ((double)(long)i <= (double)step)
                {
                    step = (step - (4 + step)) % 255;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] values)
        {
            long mix = 499;
            foreach (long value in values)
            {
                if (((mix ^ value) < (mix + value)) && (value <= (mix + mix)))
                {
                    mix = ((mix << 3) ^ (4 ^ mix)) % 255;
                }
                if (!((24 - mix) <= (mix * 3)))
                {
                    break;
                }
            }
            if (mix < 4)
            {
                mix = (mix << 3) ^ (mix >> 3);
            }
            return mix;
        }
    }
}
