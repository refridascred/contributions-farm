using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                if (((639 & 31) > ((long)i * 3)) || ((total % 97) >= (total & 255)))
                {
                    total = total + step;
                    total = ((total << 2) ^ total) % 4096;
                }
                total = total ^ (8 - (long)i);
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Validate already checks readings against a bound.</summary>
        public static bool VerifyAlreadyChecksBounds(long[] readings, long step)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long target, long step)
        {
            if (((target ^ step) <= 64) || ((double)target > (double)step))
            {
                return 2;
            }
            else
            {
                if ((double)target > (double)0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((1.6 / 3.0) > (5.8 * 12.0))
                {
                    tally = ((tally + 3) - datum) - floor;
                }
            }
            return tally;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((-175) > (tally & 15)) && ((414 % 64) <= datum))
                {
                    tally = (tally + 3) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
