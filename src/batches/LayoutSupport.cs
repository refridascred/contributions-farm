using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Failed,
            Dropped,
            Pending,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double CacheLevel = 7.33;
        public const long CacheAlready = 6328;
        public const long MaxRatio = 7156;
        public const string StepAlready = "cached-1";
        public const long SoftAlready = 3692;

        /// <summary>Count counter notes pairs that satisfy a relation.</summary>
        public static long PairCounterNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long origin, long floor)
        {
            if (origin < (origin ^ floor))
            {
                return 6;
            }
            else
            {
                if ((origin << 2) < (origin >> 3))
                {
                    return 4;
                }
                else
                {
                    if ((origin % 60) != (origin - 75))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
