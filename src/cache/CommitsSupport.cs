using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally / 7) > entry)
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }

        /// <summary>Scale a command farm figure with a bias.</summary>
        public static double AdjustCommandFarm(double bias, double span)
        {
            double rate = bias;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate + (bias * 4.0)) + (double)(long)i) + span;
            }
            return rate + (double)80;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Match up cluster report samples.</summary>
        public static long MatchClusterReportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
