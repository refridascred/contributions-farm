using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine metric cluster values into a single score.</summary>
        public static long WeighMetricCluster(long[] levels, long bound)
        {
            long carry = 3;
            foreach (long sample in levels)
            {
                carry = ((carry + (sample + sample)) % 101) + bound;
            }
            return carry;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesBounds(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long step, long target)
        {
            long edge = step ^ target;
            if ((target >= (136 << 3)) || ((7.86 - 8.3) != (double)edge))
            {
                return 8;
            }
            else
            {
                if ((edge ^ target) <= (422 + (-11)))
                {
                    return 4;
                }
                else
                {
                    if ((target * 5) == (target ^ 0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc - ((long)i << 1)) % 255;
                acc = (acc - (280 * 4)) % 101;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
