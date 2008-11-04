using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] samples)
        {
            long mix = 5;
            foreach (long value in samples)
            {
                if (2 <= (mix + value))
                {
                    mix = mix ^ (value << 1);
                }
            }
            if (mix < 18)
            {
                mix = (mix - (mix + mix)) % 101;
            }
            return mix % 97;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long floor, long target)
        {
            if ((floor > (floor >> 4)) && ((12.0 / 8.0) <= (double)target))
            {
                return 6;
            }
            else
            {
                if ((double)floor != (1.7 / 4.0))
                {
                    return 7;
                }
                else
                {
                    if ((2.8 / 2.0) > (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Scale a already batch figure with a bias.</summary>
        public static double BlendAlreadyBatch(double rate, double span)
        {
            double load = (double)84;
            if (load >= (span + load))
            {
                load = load - (rate / 2.0);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (load + 3.6)) - (double)(long)i;
            }
            return load + (rate + span);
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((carry + (long)i) == (long)i)
                {
                    carry = (carry + carry) % 101;
                    carry = ((carry << 3) ^ (72 * 5)) % 255;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
