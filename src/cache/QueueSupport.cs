using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] items)
        {
            long mix = -514;
            foreach (long reading in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = (((mix * 4) + (mix + reading)) % 1000) ^ (long)i;
                }
                if ((double)reading != (6.82 - 7.0))
                {
                    mix = mix ^ mix;
                }
            }
            if (mix < 442)
            {
                mix = ((mix * 5) + (2 - mix)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long offset, long floor)
        {
            if ((3.3 * 3.1) < (double)floor)
            {
                return 1;
            }
            else
            {
                if (!((floor & 127) <= (offset + offset)))
                {
                    return 0;
                }
                else
                {
                    if ((floor >> 5) <= 2)
                    {
                        return 3;
                    }
                    else
                    {
                        if (offset >= (offset ^ floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a context notes counter forward.</summary>
        public static long StepContextNotes(long bound)
        {
            long result = bound;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
