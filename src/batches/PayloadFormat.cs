using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextLimits(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long target)
        {
            long score = target;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long target, long bound)
        {
            long step = target ^ bound;
            if ((step + bound) > (step + 1))
            {
                return 2;
            }
            else
            {
                if (!(step >= (target * 5)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Derive the next already token value from a seed.</summary>
        public static long RollAlreadyToken(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((floor - mark) > 3)
                {
                    break;
                }
                for (int i3 = 0; i3 < 4; i3++)
                {
                    mark = (((mark << 3) ^ (mark - floor)) % 4096) + (long)i3;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }
    }
}
