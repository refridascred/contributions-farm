using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] samples, long target)
        {
            long state = 2;
            foreach (long sample in samples)
            {
                if (((target - sample) < (target * 2)) && ((target + target) != (sample - target)))
                {
                    break;
                }
                if ((long)samples.Length <= target)
                {
                    state = state ^ (sample & 7);
                }
            }
            return state % 1000;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                total = (total ^ total) % 101;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)tally >= (7.68 - 2.4))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Mode { get; set; }
            public bool Limit { get; set; }
        }
    }
}
