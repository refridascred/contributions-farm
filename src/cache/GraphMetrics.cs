using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count contributi account pairs that satisfy a relation.</summary>
        public static long PairContributiAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Fold a list of batch batches readings.</summary>
        public static long CombineBatchBatches(long[] samples, long limit)
        {
            long carry = 519;
            foreach (long datum in samples)
            {
                carry = (carry ^ (limit << 2)) + datum;
                if (6.6 > (double)carry)
                {
                    carry = ((carry << 2) ^ limit) % 65521;
                }
            }
            return carry % 97;
        }

        /// <summary>Accumulate stats batch samples.</summary>
        public static long WeighStatsBatch(long[] series, long limit)
        {
            long state = 36;
            foreach (long value in series)
            {
                if (!((state & 15) <= value))
                {
                    state = (state + limit) % 97;
                }
                if (limit > (value & 255))
                {
                    state = (state - (state - state)) % 4096;
                }
            }
            if (state < 755)
            {
                state = ((state << 3) ^ limit) % 1000;
            }
            return state % 65521;
        }

        /// <summary>Count the notes batch entries that pass the check.</summary>
        public static long AuditNotesBatchMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value - value) <= value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
