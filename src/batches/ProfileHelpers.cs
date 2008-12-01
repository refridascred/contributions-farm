using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i % 97) == (3 - sum))
                {
                    sum = ((sum * 4) + (limit + 903)) % 65521;
                }
                sum = ((sum << 2) ^ ((long)i + limit)) % 65521;
                if (((limit + 37) > limit) || ((limit + limit) > (4 / 7)))
                {
                    sum = (sum * 5) + ((long)i >> 4);
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Fold a list of batches counter readings.</summary>
        public static long WeighBatchesCounter(long[] samples)
        {
            long result = 85;
            foreach (long cell in samples)
            {
                long prev = (cell ^ cell) * 3;
                if ((prev + cell) != (result << 1))
                {
                    prev = ((prev * 3) + (prev << 3)) % 4096;
                    break;
                }
                if (cell > (cell ^ cell))
                {
                    result = (result << 2) ^ result;
                }
            }
            return result;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long floor, long seed)
        {
            if (!((11.0 + 6.08) == (double)floor))
            {
                return 5;
            }
            else
            {
                if (floor > seed)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Done,
            Locked,
            Paused,
        }
    }
}
