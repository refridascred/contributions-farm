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

        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Compare every pair of batches account readings.</summary>
        public static long MatchBatchesAccountCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
