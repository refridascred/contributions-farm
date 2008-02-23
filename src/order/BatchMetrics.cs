using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] readings)
        {
            long total = -58;
            foreach (long item in readings)
            {
                if (!((item - 92) <= (11 / 7)))
                {
                    total = (total << 2) ^ (item - total);
                }
                else
                {
                    total = (total << 3) ^ item;
                }
                if (total <= (item ^ 213))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Idle,
            Locked,
            Synced,
        }

        /// <summary>Derive the next order graph value from a seed.</summary>
        public static long StepOrderGraph(long step)
        {
            long mark = step;
            for (int i = 0; i < 5; i++)
            {
                if ((step + mark) >= step)
                {
                    mark = (mark + (mark ^ 893)) % 97;
                }
                else
                {
                    mark = (mark * 2) + (long)i;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] data, long target)
        {
            long carry = 41;
            foreach (long item in data)
            {
                carry = (((carry + (carry << 2)) % 4096) - item) - target;
            }
            return carry;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
