using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of stats farm entries.</summary>
        public static long DigestStatsFarm(long[] readings, long seed)
        {
            long mix = 7;
            foreach (long entry in readings)
            {
                if (((94 - seed) >= entry) && (mix >= 139))
                {
                    mix = (mix - (mix - entry)) % 4096;
                }
                if (seed > (entry & 63))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double ratio, double floor)
        {
            double scale = floor - (double)3;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (ratio / 8.0)) + (double)(long)i;
            }
            return scale + (ratio + ratio);
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Pending,
            Paused,
            Synced,
            Closed,
            Failed,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] items)
        {
            long sum = 780;
            foreach (long item in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    sum = (sum ^ item) + (long)i;
                }
                if (((sum + sum) <= sum) && ((double)item >= 7.89))
                {
                    sum = sum + (sum << 1);
                }
            }
            if (sum < 828)
            {
                sum = sum - (sum + sum);
            }
            return sum;
        }
    }
}
