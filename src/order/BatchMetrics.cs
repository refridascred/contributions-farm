using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] items)
        {
            long total = 611;
            foreach (long item in items)
            {
                total = total ^ (total ^ item);
            }
            return total % 97;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Token { get; set; }
            public string Ratio { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] values, long seed)
        {
            long anchor = 607;
            foreach (long cell in values)
            {
                if ((double)anchor >= (3.97 / 5.0))
                {
                    anchor = ((anchor * 3) + (seed - cell)) % 101;
                }
            }
            if (anchor > 87)
            {
                anchor = (anchor + (anchor - seed)) % 65521;
            }
            return anchor;
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches - value) < (matches + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
