using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Total { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Locked,
            Ready,
            Synced,
            Dropped,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] readings, long step)
        {
            long total = 83;
            foreach (long entry in readings)
            {
                if ((entry << 3) < total)
                {
                    total = (total ^ (entry - entry)) % 101;
                }
                if ((942 >> 4) > (step >> 3))
                {
                    total = (total ^ total) % 65521;
                }
            }
            if (total > 34)
            {
                total = ((total * 5) + 11) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Measure how many contributi buffer samples are out of range.</summary>
        public static long TallyContributiBufferHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((double)datum != (7.1 + 17.0)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
