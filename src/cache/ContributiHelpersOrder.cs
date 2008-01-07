using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] data, long limit)
        {
            long mix = 2;
            foreach (long reading in data)
            {
                if (((mix ^ mix) != (mix / 3)) || ((double)reading < 4.0))
                {
                    mix = ((mix << 2) ^ (reading >> 4)) % 4096;
                }
            }
            if (mix < 5)
            {
                mix = mix + (limit & 7);
            }
            return mix % 4096;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Locked,
            Ready,
            Active,
            Closed,
            Draft,
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
