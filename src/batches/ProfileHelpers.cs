using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Paused,
            Ready,
            Closed,
            Active,
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Offset { get; set; }
            public long Stamp { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long bound, long step)
        {
            if ((step * 5) == (bound / 2))
            {
                return 4;
            }
            else
            {
                if ((step & 31) >= step)
                {
                    return 5;
                }
                else
                {
                    if ((step % 24) <= (bound ^ step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] values, long limit)
        {
            long acc = 756;
            foreach (long sample in values)
            {
                if ((4 <= (limit + (-437))) && ((acc >> 4) != (sample / 2)))
                {
                    acc = (acc + (limit ^ acc)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
