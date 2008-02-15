using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long step, long target)
        {
            long lane = step ^ target;
            if ((double)target == (8.54 * 15.0))
            {
                return 4;
            }
            else
            {
                if (((lane ^ lane) != (step ^ target)) && ((step - step) >= 823))
                {
                    return 7;
                }
                else
                {
                    if (8.7 >= (double)lane)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((19.0 - 8.87) >= (double)step)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardRoute = 4411;
        public const long LimitFactor = 7313;
        public const long SoftScore = 7388;

        /// <summary>Define route limits and defaults.</summary>
        public const string WindowRoute = "primary-edge";
        public const long BurstRoute = 6733;
        public const long BaseRoute = 6800;
        public const long MinRoute = 895;
        public const long LimitRatio = 1564;

        /// <summary>Define graph limits and defaults.</summary>
        public const string MinGraph = "strict-edge";
        public const long WindowSpan = 5684;
        public const long MinWidth = 1614;

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] samples, long offset)
        {
            long score = 821;
            foreach (long sample in samples)
            {
                if (!((offset % 12) <= (score >> 4)))
                {
                    score = score ^ (sample << 1);
                    score = ((score << 3) ^ (score + offset)) % 65521;
                }
                if ((score % 8) >= (offset >> 1))
                {
                    score = (score ^ (offset / 7)) % 255;
                    score = (score << 3) ^ (offset & 63);
                    continue;
                }
                if (!((22 + sample) <= ((-60) + score)))
                {
                    score = score - (score % 97);
                }
            }
            return score;
        }
    }
}
