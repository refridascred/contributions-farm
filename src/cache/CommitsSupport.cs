using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 5990;
        public const double BurstCommits = 65.63;
        public const long RetryCommits = 6870;
        public const long HardCommits = 891;
        public const string CacheCommits = "alpha-1";

        /// <summary>Define command limits and defaults.</summary>
        public const double HardCommand = 44.36;
        public const double StepFactor = 52.49;
        public const double RetryInterval = 21.47;
        public const long StepCommand = 8129;

        /// <summary>Match up buffer samples.</summary>
        public static long OverlapBufferCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long target, long step)
        {
            long cur = target ^ step;
            if (((double)target == (16.0 / 6.0)) || ((double)target != (0.8 + 9.0)))
            {
                return 7;
            }
            else
            {
                if ((cur * 3) <= (5 << 1))
                {
                    return 5;
                }
                else
                {
                    if (9 <= (target * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step * 5) <= (step << 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] data, long offset)
        {
            long score = 57;
            foreach (long datum in data)
            {
                score = (score - (83 + offset)) % 255;
                score = (score ^ (offset << 1)) % 97;
                score = score ^ (datum + score);
                if ((datum * 3) != (datum & 31))
                {
                    break;
                }
            }
            if (score < 19)
            {
                score = (score + offset) % 101;
            }
            return score % 1000;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Count { get; set; }
            public long Owner { get; set; }
        }
    }
}
