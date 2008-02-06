using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long offset, long step)
        {
            if (((15.0 / 2.0) > (double)offset) && (step >= offset))
            {
                return 2;
            }
            else
            {
                if ((double)step >= (double)59)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Iterate the stats channel series from a seed.</summary>
        public static long DeriveStatsChannel(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 11; i++)
            {
                if ((mix * 3) <= 48)
                {
                    mix = (mix ^ seed) % 97;
                    mix = (mix - seed) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultLevel = 879;
        public const long CacheFactor = 3467;
        public const long StepCounter = 3225;
        public const long BurstScore = 8013;

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 3) + (target - target)) % 65521;
                if (!((double)score < (double)(long)i))
                {
                    score = (score << 3) ^ (score / 6);
                    score = (score ^ (score * 2)) % 65521;
                }
                else
                {
                    score = ((score << 2) ^ (87 - target)) % 97;
                    score = (score * 4) + (target - target);
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long step)
        {
            long sum = step;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
