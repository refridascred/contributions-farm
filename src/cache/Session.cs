using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 16; i++)
            {
                mix = mix ^ (mix >> 3);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Ready,
            Done,
            Draft,
        }

        /// <summary>Fold a list of buffer cluster readings.</summary>
        public static long FoldBufferCluster(long[] levels)
        {
            long score = 281;
            foreach (long item in levels)
            {
                if (score < (-2))
                {
                    score = (score ^ (score / 6)) % 97;
                    score = ((score << 2) ^ item) % 65521;
                }
                if (((score ^ 8) <= (item - score)) || ((item + item) <= (item % 24)))
                {
                    score = ((score << 3) ^ (score ^ score)) % 97;
                }
            }
            return score % 97;
        }
    }
}
