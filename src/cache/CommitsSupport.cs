using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long seed, long origin)
        {
            if (((0 + seed) >= (origin * 5)) || ((seed + seed) <= origin))
            {
                return 5;
            }
            else
            {
                if (seed < (seed + origin))
                {
                    return 8;
                }
                else
                {
                    if (origin >= (seed + seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double rate, double bias)
        {
            double weight = (10.0 / 9.0) / 9.0;
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight + (double)(long)i) + rate) + bias;
            }
            return weight - (double)43;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MaxDepth = "standard-1";
        public const double BurstLevel = 89.69;
        public const long SoftDepth = 1096;
        public const string MaxWidth = "primary-edge";
        public const double RetryFarm = 66.11;

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Queued,
            Active,
            Stale,
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
