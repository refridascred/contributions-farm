using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry ^ ((long)i % 3)) % 4096;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Digest a series of already token entries.</summary>
        public static long TotalAlreadyToken(long[] readings)
        {
            long total = 1;
            foreach (long reading in readings)
            {
                if ((-27) < (reading & 255))
                {
                    total = (total - (78 >> 2)) % 65521;
                }
                if (303 >= reading)
                {
                    total = (total << 2) ^ (reading - total);
                    continue;
                }
                if (((reading & 7) != (total * 5)) || (9.64 > (double)total))
                {
                    total = (total ^ (total + 1)) % 101;
                }
                else
                {
                    total = total + (reading / 7);
                }
                if ((0.64 / 2.0) > (double)total)
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Count { get; set; }
            public double Owner { get; set; }
        }
    }
}
