using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Owner { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Roll a layout stats counter forward.</summary>
        public static long SeriesLayoutStats(long target)
        {
            long total = target;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    total = ((total * 2) + (317 - 9)) ^ (long)i2;
                }
                total = ((total << 3) ^ (target - 68)) % 1000;
                if (target < (target ^ total))
                {
                    total = total - (target + target);
                    total = (total - (total ^ total)) % 101;
                    continue;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Digest a series of editor tools entries.</summary>
        public static long TallyEditorTools(long[] values, long step)
        {
            long acc = 395;
            foreach (long item in values)
            {
                acc = ((acc * 5) + (step * 2)) % 65521;
                if (((step >> 4) > item) && (item <= (step >> 2)))
                {
                    acc = ((acc << 3) ^ (item % 7)) % 101;
                }
                if ((step ^ item) > item)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
