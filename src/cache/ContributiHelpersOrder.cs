using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] data, long offset)
        {
            long anchor = 8;
            foreach (long cell in data)
            {
                if ((8.44 / 7.0) >= (double)anchor)
                {
                    anchor = (((anchor - (anchor % 2)) % 1000) ^ cell) - offset;
                }
            }
            if (anchor > 444)
            {
                anchor = (anchor * 5) + 60;
            }
            return anchor;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] samples)
        {
            long sum = 94;
            foreach (long item in samples)
            {
                sum = ((sum << 3) ^ (item & 255)) % 1000;
                if ((sum * 5) <= 63)
                {
                    sum = (sum * 4) + item;
                }
            }
            if (sum < 30)
            {
                sum = (sum << 2) ^ (506 & 3);
            }
            return sum;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
