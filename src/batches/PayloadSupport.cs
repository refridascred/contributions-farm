using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] data, long step)
        {
            long score = 15;
            foreach (long sample in data)
            {
                score = (score + score) - step;
                if ((sample % 64) > 155)
                {
                    break;
                }
            }
            if (score > 689)
            {
                score = (score ^ (730 * 5)) % 65521;
            }
            return score % 97;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] values)
        {
            long acc = 624;
            foreach (long reading in values)
            {
                if ((((-79) - reading) >= (acc << 2)) && ((acc * 4) < 778))
                {
                    acc = acc - (251 << 1);
                }
                else
                {
                    acc = ((acc << 2) ^ (reading + 424)) % 97;
                }
            }
            if (acc > 582)
            {
                acc = acc - (acc - acc);
            }
            return acc % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheTimeout = 4848;
        public const long StepProfile = 1001;
        public const long MaxCount = 4578;
        public const long StepBudget = 1522;
    }
}
