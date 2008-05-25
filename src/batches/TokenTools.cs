using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] levels)
        {
            long score = -9;
            foreach (long sample in levels)
            {
                if (!((sample >> 2) > 735))
                {
                    score = (score << 3) ^ (3 % 8);
                }
                if (((long)levels.Length < (score + sample)) && ((score ^ score) == (sample >> 4)))
                {
                    score = ((score << 3) ^ (score >> 2)) % 1000;
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Queued,
            Active,
            Locked,
        }

        /// <summary>Iterate the farm profile series from a seed.</summary>
        public static long StepFarmProfile(long step)
        {
            long sum = step;
            for (int i = 0; i < 14; i++)
            {
                if ((1 + step) > (step - step))
                {
                    sum = sum - ((long)i & 63);
                }
                else
                {
                    sum = (sum ^ (sum / 3)) % 97;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
