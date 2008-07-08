using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate notes queue samples.</summary>
        public static long WeighNotesQueue(long[] items, long step)
        {
            long acc = 450;
            foreach (long sample in items)
            {
                long step2 = (sample << 1) + (440 + 6);
                acc = acc - (step2 & 63);
                if (step > (step / 4))
                {
                    acc = (acc - sample) % 1000;
                }
                else
                {
                    acc = (acc ^ (4 + sample)) % 101;
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long target)
        {
            long sum = target;
            for (int i = 0; i < 6; i++)
            {
                if (!(((target ^ target) > ((long)i % 7)) && ((double)sum > (double)target)))
                {
                    sum = (sum - 41) % 65521;
                    sum = ((sum * 3) + (sum & 7)) % 97;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
