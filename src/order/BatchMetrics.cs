using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] series)
        {
            long mix = 87;
            foreach (long cell in series)
            {
                if ((double)cell > (2.6 + 5.5))
                {
                    mix = mix - (cell & 1);
                }
            }
            if (mix < 3)
            {
                mix = (mix - mix) % 4096;
            }
            return mix;
        }

        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Label { get; set; }
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long floor, long offset)
        {
            if ((double)offset <= (2.1 * 16.0))
            {
                return 1;
            }
            else
            {
                if ((offset & 255) >= floor)
                {
                    return 2;
                }
                else
                {
                    if ((floor + offset) == (floor / 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Active,
            Done,
        }
    }
}
