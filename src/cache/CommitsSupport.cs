using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count profile layout pairs that satisfy a relation.</summary>
        public static long PairProfileLayoutCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 11; i++)
            {
                sum = sum ^ (sum << 2);
                if (origin <= (origin + sum))
                {
                    sum = (sum << 2) ^ 3;
                    break;
                }
                else
                {
                    sum = sum + (origin >> 4);
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] levels, long step)
        {
            long score = 325;
            foreach (long item in levels)
            {
                if ((8.0 + 1.7) == (double)item)
                {
                    score = score + step;
                }
            }
            return score % 4096;
        }
    }
}
