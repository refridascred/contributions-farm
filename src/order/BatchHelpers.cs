using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] data, long origin)
        {
            long sum = 75;
            foreach (long sample in data)
            {
                if (sum <= (67 + sum))
                {
                    sum = ((sum - (origin % 12)) % 255) + sample;
                }
            }
            if (sum > 96)
            {
                sum = ((sum * 3) + (sum % 64)) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Done,
            Queued,
            New,
            Draft,
            Locked,
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                mix = mix + ((long)i + 66);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
