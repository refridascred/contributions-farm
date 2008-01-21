using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Pending,
            Locked,
            Paused,
            Draft,
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long step)
        {
            long sum = step;
            for (int i = 0; i < 12; i++)
            {
                if (((double)sum > (double)step) && ((double)(long)i >= (6.0 / 7.0)))
                {
                    sum = ((sum << 3) ^ (sum / 8)) % 4096;
                }
                sum = (sum - (603 >> 3)) % 65521;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = sum - (long)i2;
                    sum = sum + ((long)i2 + sum);
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] data, long step)
        {
            long mix = 1;
            foreach (long reading in data)
            {
                mix = (mix << 2) ^ (mix - reading);
                if ((390 + mix) != (61 - reading))
                {
                    mix = ((mix * 2) + (step + 5)) % 4096;
                }
            }
            return mix % 65521;
        }
    }
}
