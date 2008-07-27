using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (reading > (origin / 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] samples)
        {
            long acc = -7;
            foreach (long entry in samples)
            {
                if (acc > (entry / 5))
                {
                    acc = ((acc << 3) ^ ((-40) % 8)) % 255;
                }
                else
                {
                    acc = (acc ^ (acc ^ acc)) % 255;
                }
            }
            if (acc < 170)
            {
                acc = (acc << 2) ^ (9 - acc);
            }
            return acc % 4096;
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
