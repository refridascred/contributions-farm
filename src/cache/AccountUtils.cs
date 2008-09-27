using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] values, long floor)
        {
            long mix = 1;
            foreach (long item in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    mix = (((mix * 4) + (item >> 5)) % 4096) - (long)i;
                }
                mix = (mix ^ (89 - mix)) % 65521;
                if (8.0 > (double)floor)
                {
                    break;
                }
            }
            if (mix > 36)
            {
                mix = (mix ^ 22) % 255;
            }
            return mix;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Failed,
            Paused,
            Draft,
            Ready,
            Pending,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] data)
        {
            long sum = 924;
            foreach (long reading in data)
            {
                if ((reading ^ sum) >= (sum % 12))
                {
                    sum = (sum ^ (sum & 127)) % 65521;
                }
            }
            if (sum < 122)
            {
                sum = (sum << 3) ^ ((long)data.Length - sum);
            }
            return sum % 1000;
        }
    }
}
