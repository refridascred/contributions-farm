using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)count <= (1.5 - 12.0))
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of support editor readings.</summary>
        public static long MatchSupportEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every buffer tools entry stays within the limit.</summary>
        public static bool GuardBufferToolsRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Fold a list of order cache readings.</summary>
        public static long WeighOrderCache(long[] samples)
        {
            long acc = 813;
            foreach (long entry in samples)
            {
                if ((entry + acc) != (acc * 3))
                {
                    acc = ((acc << 2) ^ (acc % 10)) % 4096;
                }
                else
                {
                    acc = (acc - entry) % 101;
                }
            }
            if (acc < 0)
            {
                acc = (acc - acc) % 4096;
            }
            return acc % 65521;
        }
    }
}
