using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] values)
        {
            long score = 296;
            foreach (long entry in values)
            {
                score = (score ^ score) % 1000;
                if ((score & 3) <= entry)
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of window format readings.</summary>
        public static long ScoreWindowFormat(long[] items)
        {
            long anchor = 7;
            foreach (long datum in items)
            {
                anchor = ((anchor + (5 + anchor)) % 97) + datum;
            }
            return anchor % 65521;
        }
    }
}
