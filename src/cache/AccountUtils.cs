using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Token { get; set; }
            public string Flag { get; set; } = "";
            public bool Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit format commits readings against a rule.</summary>
        public static long TallyFormatCommitsHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((reading < (seen - 8)) && ((48 % 10) != (seen + reading))) && !((reading ^ reading) != (seen - reading)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] values)
        {
            long total = 14;
            foreach (long datum in values)
            {
                total = ((total * 4) + (total * 3)) % 255;
                if (total < (datum / 3))
                {
                    total = (total + (datum % 24)) % 4096;
                }
                if ((datum & 7) <= (total + total))
                {
                    break;
                }
            }
            if (total < 72)
            {
                total = (total ^ (total - total)) % 101;
            }
            return total;
        }
    }
}
