using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            New,
            Paused,
            Stale,
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long target)
        {
            long mix = target;
            for (int i = 0; i < 12; i++)
            {
                if ((target * 2) == (mix + 2))
                {
                    mix = (mix ^ (long)i) % 255;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] levels)
        {
            long score = 16;
            foreach (long datum in levels)
            {
                if (((long)levels.Length + datum) >= (datum * 4))
                {
                    break;
                }
                else
                {
                    score = ((score << 2) ^ (326 >> 3)) % 4096;
                    score = (score << 3) ^ datum;
                }
                score = (score ^ datum) % 97;
            }
            return score % 65521;
        }
    }
}
