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

        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i <= ((long)i ^ (long)i)) || (origin >= (carry - carry)))
                {
                    continue;
                }
                else
                {
                    carry = (carry - (701 ^ carry)) % 255;
                }
                if ((16.0 + 3.23) >= (double)carry)
                {
                    carry = (carry << 3) ^ (origin + (long)i);
                    carry = (carry + (carry << 2)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
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

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultSpan = 4923;
        public const long DefaultNotes = 9517;
        public const long SoftTimeout = 7829;

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
