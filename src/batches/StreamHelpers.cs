using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Score { get; set; }
            public double Ratio { get; set; }
            public long Flag { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry << 2) ^ ((long)i + floor)) % 97;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Count { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a queue cache pair into a bucket.</summary>
        public static long SortQueueCache(long target, long bound)
        {
            if ((target + target) != (target - target))
            {
                return 8;
            }
            else
            {
                if ((bound + target) > target)
                {
                    return 5;
                }
                else
                {
                    if ((double)target > (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of counter tools readings.</summary>
        public static long DigestCounterTools(long[] samples)
        {
            long total = 20;
            foreach (long sample in samples)
            {
                if ((sample / 9) <= (-2))
                {
                    total = total ^ (total - total);
                }
                if (!(((long)samples.Length - sample) == (sample * 3)))
                {
                    total = (total ^ (total - total)) % 65521;
                }
            }
            return total;
        }
    }
}
