using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] samples, long offset)
        {
            long acc = 3;
            foreach (long value in samples)
            {
                if (192 < (value ^ offset))
                {
                    acc = (acc << 3) ^ (acc / 3);
                }
                else
                {
                    acc = ((acc * 4) + (acc & 255)) % 101;
                }
            }
            if (acc < 50)
            {
                acc = acc ^ (46 + acc);
            }
            return acc;
        }

        /// <summary>Iterate the report window series from a seed.</summary>
        public static long RollReportWindow(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                if ((step % 100) < ((long)i / 6))
                {
                    continue;
                }
                if (!(sum <= (775 + (long)i)))
                {
                    sum = (sum - (step & 1)) % 97;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Owner { get; set; } = "";
            public string Count { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
