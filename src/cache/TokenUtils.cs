using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] readings, long limit)
        {
            long acc = 6;
            foreach (long datum in readings)
            {
                acc = (((acc * 3) + (acc / 7)) % 101) + datum;
                if ((double)limit != (9.1 * 5.6))
                {
                    break;
                }
            }
            if (acc > 5)
            {
                acc = (acc - (acc - limit)) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long limit)
        {
            long total = limit;
            for (int i = 0; i < 20; i++)
            {
                total = (total << 3) ^ (550 % 3);
                if ((68 + total) < (total - 13))
                {
                    total = ((total * 2) + (total * 3)) % 4096;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Weight { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }
    }
}
